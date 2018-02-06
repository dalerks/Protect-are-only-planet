using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;
using System.Data;
using System.Configuration;

namespace POOP
{
    public static class POOPDATA
    {

        public static decimal? GetGift(string orgid)
        {
            PoopStatsDataContext poop = new PoopStatsDataContext();

            decimal? ret = 0;
            try
            {

                var result = poop.GetGiftTotal(orgid);
                foreach (var c in result)
                {
                    ret = c.total;
                }
            }
            catch (Exception e)
            {
                //  poop.AddError(e.Message);
            }
            return ret;
        }
        public static string Getname(string orgid)
        {
            string ret = orgid;
            PoopStatsDataContext poop = new PoopStatsDataContext();
            try
            {

                var result = poop.GetOrgName(orgid);
                foreach (var c in result)
                {
                    ret = c.ORGname;
                }
                if (ret == "")
                {
                    ret = orgid;
                }
            }
            catch (Exception e)
            {
                // poop.AddError(e.Message);
            }
            return ret;
        }
    }
}