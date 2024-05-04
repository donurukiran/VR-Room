using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DynamicGrabPoint : XRGrabInteractable
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        // Set the attach point to the contact point
        if(args.interactor is XRDirectInteractor)
        {
            XRDirectInteractor directInteractor = args.interactor as XRDirectInteractor;
            attachTransform.position = directInteractor.attachTransform.position;
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        // Reset the attach point when the object is released
        attachTransform.localPosition = Vector3.zero; // Adjust this based on your object's center
    }
}
