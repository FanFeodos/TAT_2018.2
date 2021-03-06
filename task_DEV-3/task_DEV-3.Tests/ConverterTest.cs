using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace task_DEV_3.Tests
{
    [TestClass]
    public class ConverterTest
    {
 
        [TestMethod]
        public void Convert_32_to_16_result_20()
        {
            
            Converter converter = new Converter();

            string[] temp = { "32", "16" };

            string s = converter.Convertation(temp);

            Assert.AreEqual(s, "20");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InputMoreThen2arguments_result_Exception()
        {
            Converter converter = new Converter();
            string[] temp = { "11", "16", "14" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Input_all_no_number()
        {
            Converter converter = new Converter();
            string[] temp = { "Aasd", "qwe"};
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Input_first_no_number()
        {
            Converter converter = new Converter();
            string[] temp = { "Aasd", "16" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Input_second_no_number()
        {
            Converter converter = new Converter();
            string[] temp = { "16", "A" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Input_one_arguments()
        {
            Converter converter = new Converter();
            string[] temp = { "16"};
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Input_empty_string()
        {
            Converter converter = new Converter();
            string[] temp = { "", "" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void input_base_more_then_20()
        {
            Converter converter = new Converter();
            string[] temp = { "10", "21" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void input_base_less_then_2()
        {
            Converter converter = new Converter();
            string[] temp = { "10", "1" };
            string s = converter.Convertation((temp));
        }

        [TestMethod]
        public void Convert_32_to_2_result_100000()
        {

            Converter converter = new Converter();

            string[] temp = { "32", "2" };

            string s = converter.Convertation(temp);

            Assert.AreEqual(s, "100000");
        }

        [TestMethod]
        public void Convert_39_to_20_result_1J()
        {

            Converter converter = new Converter();

            string[] temp = { "39", "20" };

            string s = converter.Convertation(temp);

            Assert.AreEqual(s, "1J");
        }
        [TestMethod]
        public void Convert_198_to_10_result_198()
        {

            Converter converter = new Converter();

            string[] temp = { "198", "10" };

            string s = converter.Convertation(temp);

            Assert.AreEqual(s, "198");
        }
    }
}

