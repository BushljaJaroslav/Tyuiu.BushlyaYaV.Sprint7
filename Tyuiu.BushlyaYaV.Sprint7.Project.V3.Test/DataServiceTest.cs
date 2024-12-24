using Tyuiu.BushlyaYaV.Sprint7.Project.V3.Lib;
namespace Tyuiu.BushlyaYaV.Sprint7.Project.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\University.cvs";

            string[,] waitMatrix = {
                {" Терехова Н.В.", " Доцент",  " Алгебра и геометрия", " 708(7)", " Экзамен"},
                {" Терехова Н.В.", " Доцент",  " Дискретная математика", " 708(7)", " Экзамен"},
                {" Ведута О.В.", " Доцент", " Иностранный язык", " 215(2)", " Зачет"},
                {" Овчинникова С.В.", " Доцент", " Математический анализ", " 506(7)", " Экзамен"},
                {" Шестаков С.А.", " Преподаватель", " Основы рос-гос", " 808(7)", " Зачет"},
                {" Пряхина Е.Н.", " Доцент", " Программирование", " 1104(7)", " Экзамен"},
                {" Суханова М.В.", " Преподаватель", " Проект. деятльность", " 602(9)", " Зачет"},
                {" Горева О.М." , " Доцент", " Теор. и приклд. инфа.", " 904(7)", " Экзамен"},
                {" Шайхетдинов Р.Г.", " Преподаватель", " Физ-ра", " с/з(2)", " Зачет"},
            };
                string[,] resMatrix = ds.GetMatrix(path);
                CollectionAssert.AreEqual(resMatrix, waitMatrix);

        }
    }
    
}
    