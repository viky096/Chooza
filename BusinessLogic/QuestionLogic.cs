using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DatabaseModels;
using EntityProvider;

namespace BusinessLogic
{
    public partial class Logic
    {
        public bool AddQuestion(QuestionViewModel question)
        {

            DataAccess DA = new DataAccess(new Guid());
            question.Id = Guid.NewGuid();
            question.CreatedBy = CurrentUserId;
            question.UpdatedBy = CurrentUserId;
            question.CreatedDate = DateTime.Now;
            question.UpdatedDate = DateTime.Now;
            question.IsDeleted = false;
            return DA.AddQuestion(question);
        }
        public List<QuestionViewModel> DisplayQuestion()
        {

            DataAccess DA = new DataAccess();
            return DA.DisplayQuestion();
        }
    }
}
