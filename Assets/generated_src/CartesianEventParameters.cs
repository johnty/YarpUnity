/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CartesianEventParameters : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CartesianEventParameters(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CartesianEventParameters obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CartesianEventParameters() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_CartesianEventParameters(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ConstString type {
    set {
      yarpPINVOKE.CartesianEventParameters_type_set(swigCPtr, ConstString.getCPtr(value));
    } 
    get {
      IntPtr cPtr = yarpPINVOKE.CartesianEventParameters_type_get(swigCPtr);
      ConstString ret = (cPtr == IntPtr.Zero) ? null : new ConstString(cPtr, false);
      return ret;
    } 
  }

  public double motionOngoingCheckPoint {
    set {
      yarpPINVOKE.CartesianEventParameters_motionOngoingCheckPoint_set(swigCPtr, value);
    } 
    get {
      double ret = yarpPINVOKE.CartesianEventParameters_motionOngoingCheckPoint_get(swigCPtr);
      return ret;
    } 
  }

  public CartesianEventParameters() : this(yarpPINVOKE.new_CartesianEventParameters(), true) {
  }

}
