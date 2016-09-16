using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public partial class Logic
    {
        #region[Properties]
        private Guid CurrentUserId { get;set; }
        private Guid CurrentApplicationId { get; set; }
        #endregion
        #region[Constructor]
        public Logic(Guid currentApplicationId)
        {
            CurrentApplicationId = currentApplicationId;
        }
        public Logic(Guid currentUserId, Guid currentApplicationId)
        {
            CurrentApplicationId = currentApplicationId;
            CurrentUserId = currentUserId;
        }
        public Logic()
        {
        }
        #endregion
    }
}
