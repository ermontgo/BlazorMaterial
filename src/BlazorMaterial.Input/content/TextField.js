if (!window.BlazorMaterial) {
  window.BlazorMaterial = {};
}
if (!window.BlazorMaterial.TextField) {
  window.BlazorMaterial.TextField = {};
}

window.BlazorMaterial.TextField.AttachTo = function (textField) {
  mdc.textfield.MDCTextField.attachTo(textField);
  return true;
};
