using ObjCRuntime;

namespace controles_de_text;

public partial class ViewController : NSViewController
{
    protected ViewController(NativeHandle handle) : base(handle)
    {
        // This constructor is required if the view controller is loaded from a xib or a storyboard.
        // Do not put any initialization here, use ViewDidLoad instead.
    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        // Do any additional setup after loading the view.
        //FeedBackLabel.StringValue = string.Format("User ID: {0}",UserNameTxtField.StringValue);
        NumberTxtField.Changed += (sender, e) =>
        {
            FeedBackLabel.StringValue = $"Number: {NumberTxtField.IntValue}";
        };
    }

    public override NSObject RepresentedObject
    {
        get => base.RepresentedObject;
        set
        {
            base.RepresentedObject = value;

            // Update the view, if already loaded.
        }
    }
}