# Unity Blendshape Baker for VRChat & Clothing Design Workflows

## Overview

**Unity Blendshape Baker** is a Unity Editor tool that allows creators to permanently apply (bake) the current blendshape values on any Skinned Mesh, producing a new static mesh with the deformation locked in place.  
This tool is particularly useful when exporting VRChat avatars or character meshes with specific blendshape settings—such as facial expressions, toggles, or corrective morphs—as static meshes for use in other 3D applications.

---

## How to Use

> **For installing, read the [Wiki Installation Guide](../../wiki/Installation).**

1. **Set Blendshapes:**  
   In Unity, configure the blendshape sliders on your avatar or mesh to the desired configuration (expression, morph, toggle, etc.).

2. **Bake:**  
   Select the GameObject and use  
   `Tools > Bake Blendshapes Into Mesh`  
   from the Unity Editor menu.

3. **Export:**  
   Export the new static mesh as FBX or OBJ using Unity's export tools.

4. **Import into 3D Tools:**  
   Bring the exported mesh into CLO3D, Marvelous Designer, Blender, or any 3D application for further work.

For detailed instructions and advanced workflows, see the [Wiki](../../wiki).

---

## Key Use Cases

- **VRChat Avatars:**  
  Export avatars with custom blendshape poses for accurate expressions, toggles, and corrective shapes.

- **Clothing Design:**  
  Bake specific body or pose morphs before exporting to clothing design tools like CLO3D or Marvelous Designer, ensuring garments fit your avatar's actual in-game shape.

## Known Issues

Body shape gets scaled up, you will need to scale it back down to it's original model's size

  :3
