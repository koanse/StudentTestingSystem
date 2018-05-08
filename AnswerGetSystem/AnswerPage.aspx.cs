using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Configuration;

namespace AnswerGetSystem
{
    public partial class AnswerPage : System.Web.UI.Page
    {
        private int quest_num;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            quest_num = Convert.ToInt32(Session["quest_num"]);

            XmlDocument answer_doc = new XmlDocument();            
            string question_file = ConfigurationManager.AppSettings["question_file"].ToString();
            answer_doc.Load(question_file);

            L_question.Text+= answer_doc.DocumentElement.ChildNodes[quest_num]["question"].InnerText;

        }

        protected void B_answer_Click(object sender, EventArgs e)
        {
            string student_answer = TB_Answer.Text;
            string group = TB_group.Text;
            string FIO = TB_FIO.Text;

            XmlDocument answer_doc = new XmlDocument();
            
            string question_file = ConfigurationManager.AppSettings["question_file"].ToString();

            answer_doc.Load(question_file);
            string question = answer_doc.DocumentElement.ChildNodes[quest_num]["question"].InnerText;
            string etalon_answer = answer_doc.DocumentElement.ChildNodes[quest_num]["etalon_answer"].InnerText;

            C_Answer stud_answer = new C_Answer(FIO, group, question, etalon_answer, student_answer);

            DateTime cur_time = DateTime.Now;
            //L_question.Text = cur_time.ToString();

            string file_name = FIO.Replace(' ','_').Replace(".","").Replace(":","")+cur_time.ToString("(dd_MM_yyyy)_(hh_mm_ss)")+".xml";

            string answer_path = ConfigurationManager.AppSettings["answer_path"].ToString();
            stud_answer.SaveToFile(answer_path + file_name);
            Server.Transfer("~/ThankPage.aspx");

        }
    }
}
