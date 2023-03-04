using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



/// <summary> 
/// Levan Gogaladze
/// 823453079
/// Your description of the class here: 
///class use incomparable inteface objects that can be sorted, 
///it stores address calues with users first name, last name, zip, phone number and birth date.
/// </summary>
namespace ConsoleApplication
{
    /// <summary>
    /// 
    /// </summary>
    public class Address : IComparable<Address>
    {
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AddressLineOne { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AddressLineTwo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Zip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>


        public Address()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addressLineOne"></param>
        /// <param name="addressLineTwo"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="birthDay"></param>
        /// <param name="phoneNumber"></param>
        public Address(string firstName, string lastName, string addressLineOne, string addressLineTwo, string city, string state, int zip, DateTime birthDay, string phoneNumber)
        {
            throw new NotImplementedException();
        }
        /// <summary>  
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Address other)
        {
            Address address = other as Address;
            if (this.FirstName.CompareTo(other.FirstName) !=0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.LastName.CompareTo(other.LastName) !=0)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            else
            {
                return this.Zip.CompareTo(other.Zip);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "First Name: " + this.FirstName + " Last Name: " + this.LastName + " Zip :" + this.Zip + "\n" + " Address One: " + AddressLineOne + " Address Two " + AddressLineTwo + " City :\n" + City + " State: " + State + " Birthday :" + BirthDay + " Phone Number :" + PhoneNumber + "\n";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}