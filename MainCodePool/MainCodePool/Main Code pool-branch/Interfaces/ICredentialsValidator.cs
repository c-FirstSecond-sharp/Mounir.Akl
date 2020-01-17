using System;
namespace Interfaces
{
    internal interface ICredentialsValidator<T, Tree>
    {
        int CurrentUserId
        {
            get;
        }
        Tree TableTree
        {
            get;
        } 
        string[] ValidateCredentials(string[] credentials);
        void SelectRoles(string[] roles,string[] credentials);
    }
}
