using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AmazonProject
{
    class Asserts
    {
        public static bool AssertEquals(object objA, object objB)
        {
            
            try
            {
                return Equals(objA, objB);
            }
            catch
            {
                Console.Error.WriteLine("Not Equals");
            }
        }

        public static bool AssertNotEquals(object objA, object objB)
        {
            try
            {
                return AssertNotEquals(objA, objB);
            }
            catch
            {
                Console.Error.WriteLine("Equals");
            }            
        }

        public static bool IsTrue(object objA, object objB)
        {
            try
            {
                return IsTrue(objA, objB);
            }
            catch {
                Console.Error.WriteLine("IsFalse");
            }
            
        }

        public static bool IsFalse(object objA, object objB)
        {
            
            try
            {
                return IsFalse(objA, objB);
            }
            catch (NoSuchElementException)
            {
                Console.Error.WriteLine("IsTrue");
            }
        }
    }
}
