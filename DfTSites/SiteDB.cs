using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace DfTSites
{
    public class SiteDB
    {

        readonly SQLiteAsyncConnection db;

        //CRUD methods

        public SiteDB(string dbPath)
        {

            db = new SQLiteAsyncConnection(dbPath);
            db.DropTableAsync<Site>().Wait();  // if doesn't exist, it won't fail
            db.CreateTableAsync<Site>().Wait();

        }

        public Task<List<Site>> GetSitesAsync()
        {
            return db.Table<Site>().ToListAsync().Wait();
            //runs without errors, but does not shwo table to listview

            //ANDROID - doesn't seem to recognise DfTSites table from sqlite db and just creashes the app)

            //var data = await db.QueryAsync<Site>("SELECT * FROM [DfTSites]");

            //return data;
        }

        // get specific site
        public Task<Site> GetSiteAsync(int id)
        {
            return db.Table<Site>().Where(site => site.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveSiteAsync(Site site)

        {
            if (site.ID == 0)
            {
                return db.InsertAsync(site);
            }
            else
            {
                return db.UpdateAsync(site);

            }
        }

        public Task<int> DeleteSiteAsync(Site site)
        {
            return db.DeleteAsync(site);
        }

    }
}
