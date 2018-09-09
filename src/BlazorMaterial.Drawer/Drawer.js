if (!window.BlazorMaterial) {
  window.BlazorMaterial = {};
}
if (!window.BlazorMaterial.Drawer) {
  window.BlazorMaterial.Drawer = {};
}

window.BlazorMaterial.Drawer.AttachTo = function (drawer, persistent) {
  if (persistent) {
    mdc.drawer.MDCPersistentDrawer.attachTo(drawer);
  } else {
    mdc.drawer.MDCTemporaryDrawer.attachTo(drawer);
  }
  return true;
};
