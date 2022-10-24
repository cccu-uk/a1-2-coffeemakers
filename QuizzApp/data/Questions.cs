using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using YamlDotNet.Serialization;

namespace QuizzApp.data
{
    internal class Questions
    {
        Dictionary<Topics, Question[]> questionDict { get; } = new Dictionary<Topics, Question[]>();


        /// <summary>
        /// Get a topics questions
        /// </summary>
        public Question getQuestion(Topics topic, int round) {

            return questionDict[topic][round];

        }
        /// <summary>
        /// Get how many questions are in a certain topic
        /// </summary>
        public int getMaxQuestions(Topics topic) {

            return questionDict[topic].Length;
        }


        /// <summary>
        /// setup the questions, loading them
        /// </summary>
        public void setup() {
            string fileName = "questions.json";

            //if the file doesn't exist then we'll create the file and save the default questions to it
            
            if (!File.Exists(fileName)) {
                var file =  File.Create(fileName);
                file.Close();
                File.WriteAllText(fileName, defaultJson);
               
            }


            //load the json from the file

            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                Dictionary<Topics, Question[]> dictionary = JsonConvert.DeserializeObject<Dictionary<Topics, Question[]>>(json);
                Debug.WriteLine(dictionary[Topics.Music][0].getRandomMixedQuestions()[0]);
                
            }

        }



        public enum Topics
        {
            Music,
            Knowledge
        }



        // convert site https://tools.knowledgewalls.com/json-to-string

        private string defaultJson = "{\"Music\":[{\"question\":\"How many beans go into 1 bean\",\"rightAnswer\":\"12\",\"wrongAnswers\":[\"14\",\"21\",\"11\"]},{\"question\":\"What was the best selling song in 1990\",\"rightAnswer\":\"uncahined melody\",\"wrongAnswers\":[\"vogue\",\"the power\",\"ice ice baby\"]}],\"Knowledge\":[{\"question\":\"What year was the Eiffel Tower built\",\"rightAnswer\":\"1887\",\"wrongAnswers\":[\"1912\",\"1862\",\"1900\"]},{\"question\":\"What year was the Leaning Tower of Pisa built\",\"rightAnswer\":\"1173\",\"wrongAnswers\":[\"1200\",\"1155\",\"1182\"]}]}";




    }
}
