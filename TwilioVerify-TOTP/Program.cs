using System;
using Twilio;
using Twilio.Rest.Verify.V2.Service;
using Twilio.Rest.Verify.V2.Service.Entity;

class Program
{
    static void Main(string[] args)
    {
        //TwilioClient.Init(accountSid, authToken);
        TwilioClient.Init("AC*********", "e********");

        //-----//
        //The delete function here will allow you to delete all the factors you have created.
        //FactorResource.Delete(
        //    pathServiceSid: "VA*********",
        //    pathIdentity: "ff*******",
        //    pathSid: "YF********"
        //);
        //-----//



        //-----//
        //The create function here allows you to create a new factor.
        //var newFactor = NewFactorResource.Create(
        //    friendlyName: "Manaliza",
        //    factorType: NewFactorResource.FactorTypesEnum.Totp,
        //    pathServiceSid: "VAa*********",
        //    pathIdentity: "ff*********"
        //);

        //Console.WriteLine(newFactor.Binding);
        //-----//



        //-----//
        //In this function you can see all the functions you have created.
        //var factors = FactorResource.Read(
        //    pathServiceSid: "VA*******",
        //    pathIdentity: "ff******",
        //    limit: 20
        //);

        //foreach (var record in factors)
        //{
        //    Console.WriteLine(record.Sid);
        //}
        //-----//



        //-----//
        //Each factor created is a closed box. You have to activate it once to use it.
        //var factor = FactorResource.Update(
        //    authPayload: "015927",
        //    pathServiceSid: "VA******",
        //    pathIdentity: "ff****",
        //    pathSid: "YF******"
        //);

        //Console.WriteLine(factor.Status);
        //-----//




        //-----//
        //All your factors were activated. You can find the approved factor and match it with the user.
        //var challenge = ChallengeResource.Create(
        //    authPayload: "827429",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******"
        //);

        //Console.WriteLine(challenge.Status);


        //var secondchallenge = ChallengeResource.Create(
        //    authPayload: "842433",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******"
        //);

        //Console.WriteLine(secondchallenge.Status);

        //var thirdchallenge = ChallengeResource.Create(
        //    authPayload: "247856",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******"
        //);

        //Console.WriteLine(thirdchallenge.Status);

        //var fourthchallenge = ChallengeResource.Create(
        //    authPayload: "973047",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******""
        //);

        //Console.WriteLine(fourthchallenge.Status);

        //var fifthchallenge = ChallengeResource.Create(
        //    authPayload: "355220",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******""
        //);

        //Console.WriteLine(fifthchallenge.Status);

        //var sixthchallenge = ChallengeResource.Create(
        //    authPayload: "581935",
        //    factorSid: "YF0******",
        //    pathServiceSid: "VAa******",
        //    pathIdentity: "ff******"
        //);

        //Console.WriteLine(sixthchallenge.Status);

        //-----//

    }

}