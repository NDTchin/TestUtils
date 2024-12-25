using System.Text.RegularExpressions;

namespace WebApplication2.Utils;

public class TestMyValidator
{
    public bool IsEmail(string email)
    {
        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }

    public bool IsVietnamesePhoneNumber(string phone)
    {
        var phonePattern = @"^(0[3|5|7|8|9])[0-9]{8}$";
        return Regex.IsMatch(phone, phonePattern);
    }

    public bool IsValidUrl(string url)
    {
        var urlPattern = @"^(https?|ftp):\/\/[^\s/$.?#].[^\s]*$";
        return Regex.IsMatch(url, urlPattern);
    }
}