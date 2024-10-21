
namespace PeakForm.Model;

public class UserAccount {
    private int account_id;
    private int _id;
    private string _name;
    private string _email;
    private string _password;
    private string username;

    public UserAccount(int Account_id,int Id, string Name, string Email, string Password, string Username){
        this._id = Id;
        this._name = Name;
        this._email = Email;
        this._password = Password;
        this.username = Username;
    }
    public int Account_id {
        set { 
            this.Account_id = value;
        }
        get {
            return this.Account_id;
        }
    }
    public int Id { 
        set {
            _id = value;
        } get{ 
            return _id;
        }
    }
    public string Name {
        set {
            _name = value;
        } 
        get {
            return _name;
        }
    }
    public string Email {
        set {
            _email = value;
        } 
        get {
            return _email;
        } 
    }
    public string Password {
        set { 
            _password = value;
        } 
        get { 
            return _password;
        } 
    }
    public string UserName {
        set {
            username = value;
        } 
        get {
            return username;
        }
    }
}
