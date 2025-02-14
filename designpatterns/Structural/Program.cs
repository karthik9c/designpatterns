﻿// See https://aka.ms/new-console-template for more information
using Structural.Adapter;
using Structural.bridge;
using Structural.decorator;

Console.WriteLine("Hello, World!");

// adaptor start

ECommerceApp eCommerceAppInternal = new ECommerceApp(new InternalPayment());
eCommerceAppInternal.Order("10");

ECommerceApp eCommerceAppHDFC = new ECommerceApp(new HdfcPaymentAdapter(new HDFCService()));
eCommerceAppHDFC.Order("10");

//adaptor ends

//bridge starts

IPaymentGateway strip = new Strip();
IPaymentGateway paypal = new Paypal();

PaymentMethod creditcardStrip = new CreditCardMethod(strip);
creditcardStrip.MakePayment(10);

PaymentMethod creditcardpaypal = new CreditCardMethod(paypal);
paypal.MakePayment(10);

var file = new FileSystem();
var encryptedFile = new EncryptFile(file);
var logFile = new LogFile(encryptedFile);
//compressed similar
// bridge ends