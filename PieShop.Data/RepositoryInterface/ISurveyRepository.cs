using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Data.RepositoryInterface
{
    public interface ISurveyRepository
    {
        void AddAnswer(Answer answer);
        Survey AddSurvey(Survey survey);
        IEnumerable<Survey> GetAllSurveys();
        Survey GetServeyById(int id);
    }
}
