﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace HouseRent
{
    /// <summary>
    /// Structure for storing the House's information
    /// </summary>
    public struct House
    {
        int houseId;
        string houseName;
        Country houseCountry;
        Owner houseOwner;
        int capacity;
        int price;

        public int HouseId
        {
            get { return houseId; }
            set { houseId = value; }
        }

        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }

        public Country HouseCountry
        {
            get { return houseCountry; }
            set { houseCountry = value; }
        }

        public Owner HouseOwner
        {
            get { return houseOwner; }
            set { houseOwner = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }

    public class HousesDAL : DALGen
    {
        public HousesDAL(ref string error)
        {
            //megpróbáljuk, hogy létrejön-e a kapcsolat            
            base.CreateConnection(ref error);             
        }
           
        /// <summary>
        /// Gets the list of all houses into a house structure list (loading the structure list with 
        /// the data from DataReader). 
        /// If a valid countryId is given, then filters the results based on the countryId and on the HouseName.
        /// </summary>
        /// <param name="HouseName"> the name of the house </param>
        /// <param name="countryId"> the ID of the hpuse's country </param>
        /// <returns>the list of houses</returns>

        public List<House> GetHouseListDataReader(int countryId, ref string error)
        {
            string query = "SELECT NyaraloID, NyaraloNev, Nyaralok.OrszagID, Orszagnev, Nyaralok.TulajID, Tulajdonosok.Nev, EmailCim, Ferohely, Ar " +
                "FROM Nyaralok, Orszagok, Tulajdonosok " +
                "WHERE Nyaralok.orszagID = Orszagok.OrszagID and Nyaralok.TulajID = Tulajdonosok.TulajID ";
           
            if (countryId >= 0)
            {
                query += " and Orszagok.OrszagID = " + countryId;
            }

            SqlDataReader dataReader = ExecuteReader(query, ref error);
            List<House> houseList = new List<House>();

            if (error == "OK")
            {
                House item = new House();
                while (dataReader.Read())
                {                   
                    try
                    {
                        item.HouseId = Convert.ToInt32(dataReader["nyaraloID"]);
                        item.HouseName = dataReader["nyaraloNev"].ToString();
                        item.HouseCountry = new Country(Convert.ToInt32(dataReader["orszagID"]), dataReader["orszagNev"].ToString());
                        item.HouseOwner = new Owner(Convert.ToInt32(dataReader["tulajID"]), dataReader["Nev"].ToString(), dataReader["EmailCim"].ToString());
                        item.Capacity = Convert.ToInt32(dataReader["ferohely"]);
                        item.Price = Convert.ToInt32(dataReader["ar"]);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }
                    houseList.Add(item);
                }
            }
            CloseDataReader(dataReader);

            return houseList;
        }


        /// ugyanaz, mint az elozo, csak itt DataSet-tel dolgozunk 
        public List<House> GetHouseListDataSet(int countryId, ref string error)
        {
            string query = "SELECT NyaraloID, NyaraloNev, Nyaralok.OrszagID, Orszagnev, Nyaralok.TulajID, Tulajdonosok.Nev, EmailCim, Ferohely, Ar " +
                "FROM Nyaralok, Orszagok, Tulajdonosok " +
                "WHERE Nyaralok.orszagID = Orszagok.OrszagID and Nyaralok.TulajID = Tulajdonosok.TulajID ";
         
            if (countryId >= 0)
            {
                query += " and Orszagok.OrszagID = " + countryId;
            }
           
            DataSet ds_tabla = new DataSet();
            ds_tabla = ExecuteDS(query, ref error);

            List<House> houseList = new List<House>();

            if (error == "OK")
            {
                House item = new House();
                foreach (DataRow r in ds_tabla.Tables[0].Rows)
                {                    
                    try
                    {
                        item.HouseId = Convert.ToInt32(r["nyaraloID"]);
                        item.HouseName = r["nyaraloNev"].ToString();
                        item.HouseCountry = new Country(Convert.ToInt32(r["orszagID"]), r["orszagNev"].ToString());
                        item.HouseOwner = new Owner(Convert.ToInt32(r["tulajID"]), r["Nev"].ToString(), r["EmailCim"].ToString());
                        item.Capacity = Convert.ToInt32(r["ferohely"]);
                        item.Price = Convert.ToInt32(r["ar"]);
                    }
                    catch (Exception ex)
                    {
                        error = "Invalid data " + ex.Message;
                    }

                    houseList.Add(item);
                }
            }
            return houseList;
        }
    }
}
