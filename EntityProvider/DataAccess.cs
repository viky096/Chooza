using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProvider
{
    public partial class DataAccess:CHOOZAEntities
    {
        #region[Properties]
        private Guid CurrentUserId { get; set; }
        private Guid CurrentApplicationId { get; set; }
        #endregion
        #region[Constructor]
        public DataAccess(Guid currentApplicationId)
        {
            CurrentApplicationId = currentApplicationId;
        }
        public DataAccess(Guid currentUserId, Guid currentApplicationId)
        {
            CurrentApplicationId = currentApplicationId;
            CurrentUserId = currentUserId;
        }
        public DataAccess()
        {
        }
        #endregion
    }
}
