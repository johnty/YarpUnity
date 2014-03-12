/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TypedReaderCallbackImageRgbFloat : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypedReaderCallbackImageRgbFloat(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TypedReaderCallbackImageRgbFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypedReaderCallbackImageRgbFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_TypedReaderCallbackImageRgbFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public new void onRead(ImageRgbFloat datum) {
    yarpPINVOKE.TypedReaderCallbackImageRgbFloat_onRead__SWIG_0(swigCPtr, ImageRgbFloat.getCPtr(datum));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public new void onRead(ImageRgbFloat datum, TypedReaderImageRgbFloat reader) {
    yarpPINVOKE.TypedReaderCallbackImageRgbFloat_onRead__SWIG_1(swigCPtr, ImageRgbFloat.getCPtr(datum), TypedReaderImageRgbFloat.getCPtr(reader));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypedReaderCallbackImageRgbFloat() : this(yarpPINVOKE.new_TypedReaderCallbackImageRgbFloat(), true) {
  }

}