
namespace Fams.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Linq;
    using System.Linq;
    using System.Web.DomainServices;
    using System.Web.DomainServices.Providers;
    using System.Web.Ria;
    using System.Web.Ria.Services;
    using Fams.Web;


    // Implements application logic using the FamsDataClassesDataContext context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class PortableDomainService : LinqToSqlDomainService<FamsDataClassesDataContext>
    {

        // TODO: Consider
        // 1. Adding parameters to this method and constraining returned results, and/or
        // 2. Adding query methods taking different parameters.
        public IQueryable<COMBO_Portable> GetCOMBO_Portables()
        {
            return this.DataContext.COMBO_Portables;
        }

        public void InsertCOMBO_Portable(COMBO_Portable cOMBO_Portable)
        {
            this.DataContext.COMBO_Portables.InsertOnSubmit(cOMBO_Portable);
        }

        public void UpdateCOMBO_Portable(COMBO_Portable currentCOMBO_Portable)
        {
            this.DataContext.COMBO_Portables.Attach(currentCOMBO_Portable, this.ChangeSet.GetOriginal(currentCOMBO_Portable));
        }

        public void DeleteCOMBO_Portable(COMBO_Portable cOMBO_Portable)
        {
            this.DataContext.COMBO_Portables.Attach(cOMBO_Portable);
            this.DataContext.COMBO_Portables.DeleteOnSubmit(cOMBO_Portable);
        }
    }
}


