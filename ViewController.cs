using System;

using AppKit;
using Foundation;

using Stripe;

namespace stripexamarinmac
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.

            StripeConfiguration.SetApiKey("sk_test_BQokikJOvBiI2HlWgH4olfQ2");

            var chargeService = new StripeChargeService();
            chargeService.ExpandBalanceTransaction = true;
            chargeService.ExpandCustomer = true;
            chargeService.ExpandInvoice = true;

            StripeCharge stripeCharge = chargeService.Get("ch_1AxdE22eZvKYlo2CmHLOPLgt");
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
