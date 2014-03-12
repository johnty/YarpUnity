/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CartesianEvent : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CartesianEvent(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CartesianEvent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CartesianEvent() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_CartesianEvent(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public CartesianEventParameters cartesianEventParameters {
    set {
      yarpPINVOKE.CartesianEvent_cartesianEventParameters_set(swigCPtr, CartesianEventParameters.getCPtr(value));
    } 
    get {
      IntPtr cPtr = yarpPINVOKE.CartesianEvent_cartesianEventParameters_get(swigCPtr);
      CartesianEventParameters ret = (cPtr == IntPtr.Zero) ? null : new CartesianEventParameters(cPtr, false);
      return ret;
    } 
  }

  public CartesianEventVariables cartesianEventVariables {
    set {
      yarpPINVOKE.CartesianEvent_cartesianEventVariables_set(swigCPtr, CartesianEventVariables.getCPtr(value));
    } 
    get {
      IntPtr cPtr = yarpPINVOKE.CartesianEvent_cartesianEventVariables_get(swigCPtr);
      CartesianEventVariables ret = (cPtr == IntPtr.Zero) ? null : new CartesianEventVariables(cPtr, false);
      return ret;
    } 
  }

  public virtual void cartesianEventCallback() {
    yarpPINVOKE.CartesianEvent_cartesianEventCallback(swigCPtr);
  }

}
