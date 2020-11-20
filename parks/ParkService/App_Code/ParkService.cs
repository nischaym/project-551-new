using System.Data;
using ParkDataAccess;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class ParkService : IParkService
{
	public DataSet GetDataWithoutDB()
	{
		return ParkDA.GetParksWithoutDB();			
	}

    public DataSet GetParksFromDBWithConfig()
    {
        return ParkDA.GetParksWithConfig();
    }

    public DataSet GetParksFromDBWithOutConfig()
    {
        return ParkDA.GetParksWithOutConfig();
    }
}
