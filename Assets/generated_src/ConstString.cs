/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ConstString : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConstString(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ConstString obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConstString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ConstString(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ConstString() : this(yarpPINVOKE.new_ConstString__SWIG_0(), true) {
  }

  public ConstString(string str) : this(yarpPINVOKE.new_ConstString__SWIG_1(str), true) {
  }

  public ConstString(string str, int len) : this(yarpPINVOKE.new_ConstString__SWIG_2(str, len), true) {
  }

  public ConstString(ConstString alt) : this(yarpPINVOKE.new_ConstString__SWIG_3(ConstString.getCPtr(alt)), true) {
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
  }

  public string c_str() {
    string ret = yarpPINVOKE.ConstString_c_str(swigCPtr);
    return ret;
  }

  public string toString() {
    string ret = yarpPINVOKE.ConstString_toString__SWIG_0(swigCPtr);
    return ret;
  }

  public bool isEqual(ConstString alt) {
    bool ret = yarpPINVOKE.ConstString_isEqual__SWIG_0(swigCPtr, ConstString.getCPtr(alt));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool notEqual(ConstString alt) {
    bool ret = yarpPINVOKE.ConstString_notEqual__SWIG_0(swigCPtr, ConstString.getCPtr(alt));
    if (yarpPINVOKE.SWIGPendingException.Pending) throw yarpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isEqual(string str) {
    bool ret = yarpPINVOKE.ConstString_isEqual__SWIG_1(swigCPtr, str);
    return ret;
  }

  public bool notEqual(string str) {
    bool ret = yarpPINVOKE.ConstString_notEqual__SWIG_1(swigCPtr, str);
    return ret;
  }

  public int length() {
    int ret = yarpPINVOKE.ConstString_length(swigCPtr);
    return ret;
  }

  public new int find(string needle) {
    int ret = yarpPINVOKE.ConstString_find__SWIG_0(swigCPtr, needle);
    return ret;
  }

  public new int find(string needle, int start) {
    int ret = yarpPINVOKE.ConstString_find__SWIG_1(swigCPtr, needle, start);
    return ret;
  }

  public ConstString substr(int start, int n) {
    ConstString ret = new ConstString(yarpPINVOKE.ConstString_substr__SWIG_0(swigCPtr, start, n), true);
    return ret;
  }

  public ConstString substr(int start) {
    ConstString ret = new ConstString(yarpPINVOKE.ConstString_substr__SWIG_1(swigCPtr, start), true);
    return ret;
  }

  public ConstString substr() {
    ConstString ret = new ConstString(yarpPINVOKE.ConstString_substr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public static int npos {
    set {
      yarpPINVOKE.ConstString_npos_set(value);
    } 
    get {
      int ret = yarpPINVOKE.ConstString_npos_get();
      return ret;
    } 
  }

  public new static ConstString toString(int x) {
    ConstString ret = new ConstString(yarpPINVOKE.ConstString_toString__SWIG_1(x), true);
    return ret;
  }

}
