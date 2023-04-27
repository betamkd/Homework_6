//Homework 5 - Da se napise C# conzolna aplikacija, kade ke se iskotisti ovoj 
//email template za da se zamenat informaciite vo zagradite []. 


using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;

string[] YourName = {"Adam", "Alice", "Ben", "Beth", "Charlie", "Claire", "Dave", "Debby", "Emily", "Eric",
"Frank", "Fiona", "Gary", "Gina", "Harry", "Hannah", "Ian", "Isabel", "Jack", "Jill",
"Kevin", "Karen", "Liam", "Lucy", "Matt", "Maggie", "Nick", "Natalie", "Oliver", "Olivia",
"Paul", "Penny", "Quinn", "Queenie", "Ryan", "Rachel", "Steve", "Samantha", "Tom", "Tina",
"Ursula", "Ulrich", "Vicky", "Vincent", "Wendy", "Will", "Winnie", "Xavier", "Xena" };

string SenderName = "Filip";
string Company = "SMX";
string discount = "80%";
string product = "CORUSE";
string benefit = "BUY THIS OFFER";
string code = "SMX80"; 

Console.WriteLine("Don't Miss Out on Our Limited-Time Offer\r\n");
foreach (string name in YourName)
{ 
Console.WriteLine($"Dear {name},\r\n" +
	$"We hope this email finds you well. \r\n" +
	$"As a valued member of {Company}, we wanted to let you know about our latest promotion. \r\n    " +
	$"\r\nFor a limited time only, we're offering {discount}. \r\n    " +
	$"\r\nThis is your chance to {benefit}.\r\n    \r\nAt {Company}, we're committed to providing our customers with high-quality products and exceptional service. " +
	$"\r\nOur {product} has received rave reviews from satisfied customers, and we're confident that you'll love it too.\r\nTo take advantage of this offer, simply visit our website and use the promo code {code} at checkout. " +
	$"\r\nThis offer is only available for a limited time, so don't wait too long to make your purchase.\r\n    \r\nIf you have any questions about our products or this promotion, \r\nplease don't hesitate to reach out to our customer service team. \r\n    " +
	$"\r\nWe're always here to help.\r\n    " +
	$"\r\nThank you for choosing {Company}, and we look forward to serving you again in the future." +
	$"\r\nBest regards," +
	$"\r\n{SenderName}" +
	$"\r\n{Company}\r\n" +
	"*************************************\r\n");
}

