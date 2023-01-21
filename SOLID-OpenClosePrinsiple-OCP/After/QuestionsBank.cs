using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OpenClosePrinsiple_OCP.After
{
    internal class QuestionsBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WHQuestions
                {
                    Title = "What are the four pillars of OOP?",
                    Mark = 8
                },
                new MultipleChoiceQuestions
                {
                    Title = "Which of the following are value types?",
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
               new TrueFalseQuestions
                {
                    Title = "Earth is Bigger than sun?",
                    Mark = 4
                },
                new MultipleChoiceQuestions
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    Mark = 6,
                    Choices = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                },
                new MatchingQuestions
                {
                    Title = "Match Column One values with single choice from 2nd Column?",
                    Mark = 20,
                    Rows =
                    {
                        {"A","Ball"},
                        {"B","Dog"},
                        {"C","Apple"},
                        {"D","Cat"},
                    }
                }

            };
        }
    }
}
