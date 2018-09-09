if (!window.BlazorMaterial) {
  window.BlazorMaterial = {};
}

window.BlazorMaterial.AddRipple = function (button) {
  mdc.ripple.MDCRipple.attachTo(button);
  return true;
}
