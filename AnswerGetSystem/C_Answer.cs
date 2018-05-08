using System.Xml;

namespace AnswerGetSystem
{
    class C_Answer
    {
        private string FIO;
        public string p_FIO
        {
            get { return FIO; }
        }

        private string group;
        public string p_group
        {
            get { return group; }
        }

        private string question;
        public string p_question
        {
            get { return question; }
        }

        private string etalon_answer;
        public string p_etalon_answer
        {
            get { return etalon_answer; }
        }

        private string student_answer;
        public string p_student_answer
        {
            get { return student_answer; }
        }

        public C_Answer(string in_FIO, string in_group, string in_question, string in_etalon_answer, string in_student_answer)
        {
            FIO = in_FIO;
            group = in_group;
            question = in_question;
            etalon_answer = in_etalon_answer;
            student_answer = in_student_answer;
            return;
        }

        public C_Answer(string XML_file_path)
        {
            XmlDocument answer_doc = new XmlDocument();
            answer_doc.Load(XML_file_path);
            XmlElement main_element = answer_doc.DocumentElement;
            FIO = main_element["FIO"].InnerText;
            group = main_element["group"].InnerText;
            question = main_element["question"].InnerText;
            etalon_answer = main_element["etalon_answer"].InnerText;
            student_answer = main_element["student_answer"].InnerText;
            return;

        }

        public void SaveToFile(string file_path)
        {
            XmlDocument answer_doc = new XmlDocument();
            XmlElement cur_root = answer_doc.CreateElement("Answer_Information");
            answer_doc.AppendChild(cur_root);
            answer_doc.PreserveWhitespace = true;

            AddXMLElement("FIO", p_FIO, answer_doc, cur_root);
            AddXMLElement("group", p_group, answer_doc, cur_root);
            AddXMLElement("question", p_question, answer_doc, cur_root);
            AddXMLElement("etalon_answer", p_etalon_answer, answer_doc, cur_root);
            AddXMLElement("student_answer", p_student_answer, answer_doc, cur_root);

            answer_doc.Save(file_path);
        }

        private void AddXMLElement(string elem_name, string elem_val, XmlDocument main_doc, XmlElement parent)
        {
            XmlElement FIO_elem = main_doc.CreateElement(elem_name);
            FIO_elem.InnerText = elem_val;
            parent.AppendChild(FIO_elem);
            return;
        }

    }
}