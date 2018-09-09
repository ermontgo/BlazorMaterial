if (!window.BlazorMaterial) {
  window.BlazorMaterial = {};
}
if (!window.BlazorMaterial.TopAppBar) {
  window.BlazorMaterial.TopAppBar = {};
}

window.BlazorMaterial.TopAppBar.AttachTo = function (topAppBar) {
  mdc.topAppBar.MDCTopAppBar.attachTo(topAppBar);
  return true;
};
