﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public static class Services_appareils
    {
        public static List<APP> Read_appareil_by_ID(int appID)
        {

            List<APP> retVal = new List<APP>();

            retVal.Add(DAL.AccesApp.Read_App_By_ID(appID));

            return retVal;

        }

        public static int Add_new_app(APP app)
        {
            return DAL.AccesApp.Add_new_app(app);
        }

        public static List<APP> Read_all_app()
        {
            return DAL.AccesApp.Read_all();
        }

        //public static APP Read_app_by_desc(string app_des)
        //{
        //    return DAL.AccesApp.Read_app_by_desc(app_des);
        //}

        public static List<APP> search_app_by_desc(string app_desc)
        {

            List<APP> retVal = new List<APP>();

            retVal.Add(DAL.AccesApp.Read_app_by_desc(app_desc));

            return retVal;

        }

    }
}
