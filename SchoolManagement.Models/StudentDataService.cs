using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SchoolManagement.Models
{
    public class StudentDataService : IDataService<Student>
    {
        List<Student> students;
        public StudentDataService()//voici un constructeur et pour generer un constructeur tu ecrit ctor + tab + tab
        {
            initValue();
        }

		
        public IEnumerable<Student> GetAll()
        {
            foreach (Student g in students)
            {
				
                yield return g;
            }
        }

		public IEnumerable<Student> SearchByRegistrationNumber(string number)
		{
			return students.Where(s => s.RegistrationNumber == number);
		}
        private void initValue()
        {
			students = new List<Student>() {
				new Student{ StudentId = 1000, RegistrationNumber = "2014672", FirstName = "Jeanette", LastName = "Weber" },
				new Student{ StudentId = 1001, RegistrationNumber = "1717683", FirstName = "Teegan", LastName = "Dotson" },
				new Student{ StudentId = 1002, RegistrationNumber = "0876316", FirstName = "Deanna", LastName = "Osborne" },
				new Student{ StudentId = 1003, RegistrationNumber = "1835010", FirstName = "Nola", LastName = "Mcguire" },
				new Student{ StudentId = 1004, RegistrationNumber = "0218682", FirstName = "Constance", LastName = "Bonner" },
				new Student{ StudentId = 1005, RegistrationNumber = "0234916", FirstName = "Willow", LastName = "Schroeder" },
				new Student{ StudentId = 1006, RegistrationNumber = "0631556", FirstName = "Chloe", LastName = "Dillon" },
				new Student{ StudentId = 1007, RegistrationNumber = "0198947", FirstName = "Gil", LastName = "Warren" },
				new Student{ StudentId = 1008, RegistrationNumber = "1005394", FirstName = "James", LastName = "Reed" },
				new Student{ StudentId = 1009, RegistrationNumber = "0882940", FirstName = "Vladimir", LastName = "Burks" },
				new Student{ StudentId = 1010, RegistrationNumber = "1118220", FirstName = "Olympia", LastName = "Wiley" },
				new Student{ StudentId = 1011, RegistrationNumber = "0584799", FirstName = "Julian", LastName = "Navarro" },
				new Student{ StudentId = 1012, RegistrationNumber = "2070004", FirstName = "Chastity", LastName = "Clemons" },
				new Student{ StudentId = 1013, RegistrationNumber = "1466203", FirstName = "Tad", LastName = "Mays" },
				new Student{ StudentId = 1014, RegistrationNumber = "0120992", FirstName = "Orla", LastName = "Morales" },
				new Student{ StudentId = 1015, RegistrationNumber = "1365546", FirstName = "Keely", LastName = "Valenzuela" },
				new Student{ StudentId = 1016, RegistrationNumber = "2102338", FirstName = "Ivor", LastName = "Hahn" },
				new Student{ StudentId = 1017, RegistrationNumber = "1717302", FirstName = "Ignacia", LastName = "Duffy" },
				new Student{ StudentId = 1018, RegistrationNumber = "1349515", FirstName = "Davis", LastName = "Emerson" },
				new Student{ StudentId = 1019, RegistrationNumber = "1027699", FirstName = "Mohammad", LastName = "Schneider" },
				new Student{ StudentId = 1020, RegistrationNumber = "0784667", FirstName = "Raja", LastName = "Mcfarland" },
				new Student{ StudentId = 1021, RegistrationNumber = "0447914", FirstName = "Carter", LastName = "Oneill" },
				new Student{ StudentId = 1022, RegistrationNumber = "1463918", FirstName = "Daniel", LastName = "Cruz" },
				new Student{ StudentId = 1023, RegistrationNumber = "2158979", FirstName = "Cedric", LastName = "Carver" },
				new Student{ StudentId = 1024, RegistrationNumber = "0754054", FirstName = "Kareem", LastName = "Hicks" },
				new Student{ StudentId = 1025, RegistrationNumber = "1579035", FirstName = "Davis", LastName = "Jackson" },
				new Student{ StudentId = 1026, RegistrationNumber = "0797469", FirstName = "Lacy", LastName = "Fitzpatrick" },
				new Student{ StudentId = 1027, RegistrationNumber = "1186837", FirstName = "Dennis", LastName = "Moore" },
				new Student{ StudentId = 1028, RegistrationNumber = "1235814", FirstName = "Sigourney", LastName = "Barker" },
				new Student{ StudentId = 1029, RegistrationNumber = "1667081", FirstName = "Adria", LastName = "Stein" },
				new Student{ StudentId = 1030, RegistrationNumber = "1473046", FirstName = "Kaye", LastName = "Clay" },
				new Student{ StudentId = 1031, RegistrationNumber = "1005015", FirstName = "Jerry", LastName = "York" },
				new Student{ StudentId = 1032, RegistrationNumber = "1889446", FirstName = "Oliver", LastName = "Solis" },
				new Student{ StudentId = 1033, RegistrationNumber = "1634008", FirstName = "Yetta", LastName = "Carney" },
				new Student{ StudentId = 1034, RegistrationNumber = "1017077", FirstName = "Harlan", LastName = "Espinoza" },
				new Student{ StudentId = 1035, RegistrationNumber = "1548063", FirstName = "Channing", LastName = "Howell" },
				new Student{ StudentId = 1036, RegistrationNumber = "1394448", FirstName = "Nadine", LastName = "Henry" },
				new Student{ StudentId = 1037, RegistrationNumber = "1394585", FirstName = "Hashim", LastName = "Carson" },
				new Student{ StudentId = 1038, RegistrationNumber = "1827520", FirstName = "Taylor", LastName = "West" },
				new Student{ StudentId = 1039, RegistrationNumber = "1155078", FirstName = "Lydia", LastName = "Guzman" },
				new Student{ StudentId = 1040, RegistrationNumber = "0690496", FirstName = "Sara", LastName = "Sutton" },
				new Student{ StudentId = 1041, RegistrationNumber = "1350102", FirstName = "Ethan", LastName = "Murray" },
				new Student{ StudentId = 1042, RegistrationNumber = "2036655", FirstName = "Ella", LastName = "Combs" },
				new Student{ StudentId = 1043, RegistrationNumber = "1963192", FirstName = "Stuart", LastName = "Benjamin" },
				new Student{ StudentId = 1044, RegistrationNumber = "0354363", FirstName = "Yardley", LastName = "Chambers" },
				new Student{ StudentId = 1045, RegistrationNumber = "1875641", FirstName = "Wing", LastName = "Cross" },
				new Student{ StudentId = 1046, RegistrationNumber = "1395987", FirstName = "Maxwell", LastName = "Golden" },
				new Student{ StudentId = 1047, RegistrationNumber = "0142801", FirstName = "Reuben", LastName = "Camacho" },
				new Student{ StudentId = 1048, RegistrationNumber = "0244144", FirstName = "Arsenio", LastName = "Hart" },
				new Student{ StudentId = 1049, RegistrationNumber = "0533930", FirstName = "Dai", LastName = "Warren" },
				new Student{ StudentId = 1050, RegistrationNumber = "1785147", FirstName = "Lacey", LastName = "Boyer" },
				new Student{ StudentId = 1051, RegistrationNumber = "0478999", FirstName = "Kevyn", LastName = "Mathis" },
				new Student{ StudentId = 1052, RegistrationNumber = "1780756", FirstName = "Sybill", LastName = "Bruce" },
				new Student{ StudentId = 1053, RegistrationNumber = "0789355", FirstName = "Katelyn", LastName = "Ramos" },
				new Student{ StudentId = 1054, RegistrationNumber = "1610830", FirstName = "Azalia", LastName = "Wallace" },
				new Student{ StudentId = 1055, RegistrationNumber = "1660872", FirstName = "Connor", LastName = "Hicks" },
				new Student{ StudentId = 1056, RegistrationNumber = "2192653", FirstName = "Steel", LastName = "Christensen" },
				new Student{ StudentId = 1057, RegistrationNumber = "0709469", FirstName = "Carlos", LastName = "Walton" },
				new Student{ StudentId = 1058, RegistrationNumber = "0139850", FirstName = "Jarrod", LastName = "Kane" },
				new Student{ StudentId = 1059, RegistrationNumber = "0254649", FirstName = "Amal", LastName = "Whitaker" },
				new Student{ StudentId = 1060, RegistrationNumber = "2157223", FirstName = "Stuart", LastName = "Durham" },
				new Student{ StudentId = 1061, RegistrationNumber = "1615631", FirstName = "Destiny", LastName = "Pollard" },
				new Student{ StudentId = 1062, RegistrationNumber = "1818470", FirstName = "Zia", LastName = "Barr" },
				new Student{ StudentId = 1063, RegistrationNumber = "0925848", FirstName = "Indira", LastName = "Hamilton" },
				new Student{ StudentId = 1064, RegistrationNumber = "0278263", FirstName = "Priscilla", LastName = "Suarez" },
				new Student{ StudentId = 1065, RegistrationNumber = "1226388", FirstName = "Cedric", LastName = "Sears" },
				new Student{ StudentId = 1066, RegistrationNumber = "2123731", FirstName = "Rae", LastName = "Whitney" },
				new Student{ StudentId = 1067, RegistrationNumber = "0589626", FirstName = "Evan", LastName = "Duke" },
				new Student{ StudentId = 1068, RegistrationNumber = "1468818", FirstName = "Yuri", LastName = "Burns" },
				new Student{ StudentId = 1069, RegistrationNumber = "1368322", FirstName = "Hollee", LastName = "Valenzuela" },
				new Student{ StudentId = 1070, RegistrationNumber = "0124554", FirstName = "Moses", LastName = "Kidd" },
				new Student{ StudentId = 1071, RegistrationNumber = "1406152", FirstName = "Dominique", LastName = "Ayers" },
				new Student{ StudentId = 1072, RegistrationNumber = "1954455", FirstName = "Thaddeus", LastName = "Joseph" },
				new Student{ StudentId = 1073, RegistrationNumber = "0594614", FirstName = "Eve", LastName = "Pierce" },
				new Student{ StudentId = 1074, RegistrationNumber = "0985072", FirstName = "Martin", LastName = "Russo" },
				new Student{ StudentId = 1075, RegistrationNumber = "1210811", FirstName = "Gavin", LastName = "Mclaughlin" },
				new Student{ StudentId = 1076, RegistrationNumber = "0779068", FirstName = "Lynn", LastName = "Mckinney" },
				new Student{ StudentId = 1077, RegistrationNumber = "0695728", FirstName = "Dale", LastName = "Figueroa" },
				new Student{ StudentId = 1078, RegistrationNumber = "0979067", FirstName = "Desiree", LastName = "Dennis" },
				new Student{ StudentId = 1079, RegistrationNumber = "0836308", FirstName = "Chastity", LastName = "Juarez" },
				new Student{ StudentId = 1080, RegistrationNumber = "0692091", FirstName = "Hamilton", LastName = "Griffin" },
				new Student{ StudentId = 1081, RegistrationNumber = "1991534", FirstName = "Edan", LastName = "Horn" },
				new Student{ StudentId = 1082, RegistrationNumber = "2080300", FirstName = "Halla", LastName = "Morris" },
				new Student{ StudentId = 1083, RegistrationNumber = "1186220", FirstName = "Bert", LastName = "Davenport" },
				new Student{ StudentId = 1084, RegistrationNumber = "1697810", FirstName = "Gannon", LastName = "Rollins" },
				new Student{ StudentId = 1085, RegistrationNumber = "1395956", FirstName = "Teagan", LastName = "Morgan" },
				new Student{ StudentId = 1086, RegistrationNumber = "1720664", FirstName = "Kimberley", LastName = "Bass" },
				new Student{ StudentId = 1087, RegistrationNumber = "0439949", FirstName = "Hilary", LastName = "Armstrong" },
				new Student{ StudentId = 1088, RegistrationNumber = "0559648", FirstName = "Cade", LastName = "Payne" },
				new Student{ StudentId = 1089, RegistrationNumber = "1940839", FirstName = "Kuame", LastName = "Huber" },
				new Student{ StudentId = 1090, RegistrationNumber = "0423419", FirstName = "Brian", LastName = "Spencer" },
				new Student{ StudentId = 1091, RegistrationNumber = "1637510", FirstName = "Lacota", LastName = "Cannon" },
				new Student{ StudentId = 1092, RegistrationNumber = "0230880", FirstName = "Honorato", LastName = "Beasley" },
				new Student{ StudentId = 1093, RegistrationNumber = "1522022", FirstName = "Clare", LastName = "Winters" },
				new Student{ StudentId = 1094, RegistrationNumber = "1986328", FirstName = "Bryar", LastName = "Harrington" },
				new Student{ StudentId = 1095, RegistrationNumber = "0352235", FirstName = "Christian", LastName = "Summers" },
				new Student{ StudentId = 1096, RegistrationNumber = "1947418", FirstName = "Dahlia", LastName = "Erickson" },
				new Student{ StudentId = 1097, RegistrationNumber = "1384517", FirstName = "Paul", LastName = "Kent" },
				new Student{ StudentId = 1098, RegistrationNumber = "1159610", FirstName = "Melodie", LastName = "Maldonado" },
				new Student{ StudentId = 1099, RegistrationNumber = "2110666", FirstName = "Kameko", LastName = "Burgess" }
			};
		}
    }
}
