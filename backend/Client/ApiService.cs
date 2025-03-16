using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Services
{
	public class ApiService
	{
		private static List<User> _users = new List<User>();

		public async Task<List<User>> GetUsersAsync()
		{
			// ���������� ������ �������������
			return await Task.FromResult(_users);
		}

		public async Task AddUserAsync(User user)
		{
			// ��������� ID (� �������� ���������� ��� �������� ����� ���� ������)
			user.Id = Guid.NewGuid().ToString(); 

			// ��������� ������������ � ������
			_users.Add(user);

			await Task.CompletedTask;
		}
	}
}