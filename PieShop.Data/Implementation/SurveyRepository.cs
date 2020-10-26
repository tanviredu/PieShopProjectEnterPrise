using PieShop.Data.RepositoryInterface;
using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PieShop.Data.Implementation
{
    public class SurveyRepository : ISurveyRepository
    {
        public readonly AppDbContext _appDbContext;

        public SurveyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddAnswer(Answer answer)
        {
            _appDbContext.Answers.Add(answer);
            _appDbContext.SaveChanges();
        }

        public Survey AddSurvey(Survey survey)
        {
            var addEntity = _appDbContext.Surveys.Add(survey);
            _appDbContext.SaveChanges();
            return addEntity.Entity;
        }

        public IEnumerable<Survey> GetAllSurveys()
        {
            /* WE CAN ADD EGARLOAD THIS BUT WE DID NOT
               YOU CAN ADD IF YOU WANT
             */
            return _appDbContext.Surveys.Select(s => s).ToList();
        }

        public Survey GetServeyId(int id)
        {
            /* EGAR LOADING THE SEARCH IT WILL TAKE ALL THE
             * ANSWERS RELATED TO THE SURVEY 
             */
            return _appDbContext.Surveys.Include(x => x.Answers).FirstOrDefault(x => x.SurveyId == id);

        }
    }
}
