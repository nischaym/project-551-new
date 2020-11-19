using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ParkDataAccess
{
    public class ParkDA
    {
        public static DataSet GetParksWithoutDB()
        {
            DataSet parksInformation = new DataSet();

            parksInformation.DataSetName = "Parks";
            DataTable dt = new DataTable("Parks");

            dt.Clear();

            dt.Columns.Add(new DataColumn("Id", typeof(int)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Location", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("Rank", typeof(int)));
            dt.Columns.Add(new DataColumn("PhotoPath", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["Id"] = 1;
            dr["Name"] = "Yosemite National Park";
            dr["Location"] = "California";
            dr["Description"] = "Yosemite National Park is in California’s Sierra Nevada mountains. It’s famed for its giant, ancient sequoia trees, and for Tunnel View, the iconic vista of towering Bridalveil Fall and the granite cliffs of El Capitan and Half Dome.";
            dr["Rank"] = 1;
            dr["PhotoPath"] = "https://media.cntraveler.com/photos/5f4d76dd7542911efadbef61/16:9/w_2560%2Cc_limit/Yosemite-GettyImages-164289875.jpg";

            dt.Rows.Add(dr);


            DataRow dr2 = dt.NewRow();
            dr2["Id"] = 2;
            dr2["Name"] = "Yellowstone National Park";
            dr2["Location"] = "Idaho, Montana";
            dr2["Description"] = "Yellowstone National Park is a nearly 3,500-sq.-mile wilderness recreation area atop a volcanic hot spot. Mostly in Wyoming, the park spreads into parts of Montana and Idaho too.";
            dr2["Rank"] = 2;
            dr2["PhotoPath"] = "https://d3fldh011ywsk8.cloudfront.net/wp-content/uploads/2020/06/Yellowstone-feature612020-768x403.jpg";

            dt.Rows.Add(dr2);


            parksInformation.Tables.Add(dt);

            return parksInformation;

        }
    }
}
