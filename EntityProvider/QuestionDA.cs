using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DatabaseModels;

namespace EntityProvider
{
    public partial class DataAccess
    {
        public bool AddQuestion(QuestionViewModel model)
        {
            Question question = new Question();
            question.Question_ID = model.Id;
            question.Statement = model.Statement;
            question.Result = model.Result;
            question.CreatedBy = model.CreatedBy;
            question.UpdatedBy = model.UpdatedBy;
            question.CreatedDate = model.CreatedDate;
            question.UpdatedDate = model.UpdatedDate;
            question.IsDeleted = model.IsDeleted;
            Questions.Add(question);
            return SaveChanges() > 0;

        }
        public List<QuestionViewModel> DisplayQuestion()
        {
            List<QuestionViewModel> QuestionList = (from q in Questions
                                          where (q.IsDeleted == null || q.IsDeleted == false)

                                          select new QuestionViewModel

                                          //
                                          {
                                              Id = q.Question_ID,
                                              Statement = q.Statement,
                                              


                                          }).ToList();

            return QuestionList;



        }
    }
}
