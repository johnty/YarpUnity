/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ImageRgbFloat : Image {
  private HandleRef swigCPtr;

  internal ImageRgbFloat(IntPtr cPtr, bool cMemoryOwn) : base(yarpPINVOKE.ImageRgbFloat_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ImageRgbFloat obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageRgbFloat() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          yarpPINVOKE.delete_ImageRgbFloat(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override int getPixelSize() {
    int ret = yarpPINVOKE.ImageRgbFloat_getPixelSize(swigCPtr);
    return ret;
  }

  public override int getPixelCode() {
    int ret = yarpPINVOKE.ImageRgbFloat_getPixelCode(swigCPtr);
    return ret;
  }

  public PixelRgbFloat pixel(int x, int y) {
    PixelRgbFloat ret = new PixelRgbFloat(yarpPINVOKE.ImageRgbFloat_pixel(swigCPtr, x, y), false);
    return ret;
  }

  public PixelRgbFloat access(int x, int y) {
    PixelRgbFloat ret = new PixelRgbFloat(yarpPINVOKE.ImageRgbFloat_access(swigCPtr, x, y), false);
    return ret;
  }

  public PixelRgbFloat safePixel(int x, int y) {
    PixelRgbFloat ret = new PixelRgbFloat(yarpPINVOKE.ImageRgbFloat_safePixel__SWIG_0(swigCPtr, x, y), false);
    return ret;
  }

  public ImageRgbFloat() : this(yarpPINVOKE.new_ImageRgbFloat(), true) {
  }

}
