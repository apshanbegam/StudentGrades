
namespace StudentGrade
{

	public class Student
	{
		private string _name { get; set; }
		private char _grade { get; set; }
		private int _group;
		private string _secretNickName = "MySecretNickName";

		public Student(string name, char grade, int group)
		{
			_name = name;
			_grade = grade;
			_group = group;
		}

		public static char[] validGrades = { 'A', 'B', 'C', 'D', 'E', 'F' };
		public static int[] validGroups = { 1, 2, 3, 4, 5, };


		private static bool CheckValidGrade(char grade)
		{
			return validGrades.Contains(grade);
		}

		private static bool CheckValidGroup(int group)
		{
			return validGroups.Contains(group);
		}

		public void UpgradeGrade()
		{
			if (CheckValidGroup(_group) & CheckValidGrade(_grade))
			{
				if (_grade != 'A')
				{

					char UpgradedGrade = (char)(_grade - 1);
					Console.WriteLine("The Upgraded grade for " + _name + " is " + UpgradedGrade);

				}
				else
				{
					Console.WriteLine("For " + _name + " We can't upgrade the grade more than 'A'");

				}
            }
            else
            {
				Console.WriteLine(_name + " is not in valid Group/Grade");

			}

		}

		public void  DowngradeGrade()
		{
			if (CheckValidGroup(_group) & CheckValidGrade(_grade))
            {
				if (_grade != 'F')
				{
					char DowngradedGrade = (char)(_grade + 1);
					Console.WriteLine("The Downgraded grade for " + _name + " is " + DowngradedGrade);

				}
				else
				{
					Console.WriteLine("For " + _name + " We can't downgrade the grade more than 'F'");

				}
			}
			else
			{
				Console.WriteLine(_name + " is not in valid Group/Grade");

			}



		}
	}

}