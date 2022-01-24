using BuildManager.Commands;
using BuildManager.Commands.RegisterPageCommand;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk;
using BuildManager.GeneralFunk.Repos;
using BuildManager.GeneralFunk.Repos.Base;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Windows;

namespace BuildManager.ViewModels
{
    public class RegistrationPageViewModel : ViewModel
    {
        public string login { get; set; } = "";
        public string password { get; set; } = "";
        public string password2 { get; set; } = "";
        public string email { get; set; } = "";

        #region Command

        public BackFromRegistrationApplicationCommand backFromRegistration { get; }

        private AddUserCommand _addCommand;
        public AddUserCommand AddCommand
        {
            get
            {
                return _addCommand ?? (new AddUserCommand(obj =>
                {
                    if (login.Length > 0 && password == password2 &&
                    email.Contains("@") && email.Contains(".") && email.Length > 0)
                    {
                        addUser();
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Something incorrect");
                    }
                }));
            }
        }

        public void addUser()
        {
            using (IRepository<User> repository = new UserRepos())
            {
                User user = new User(login, email, password);
                repository.Add(user);
            }
           
            var changePage = new GenerateFunk();
            changePage.ChangePageForMainWindow(new LoginPage());

        }

        #endregion

        public RegistrationPageViewModel()
        {
            backFromRegistration = new BackFromRegistrationApplicationCommand();

        }
    }
}
