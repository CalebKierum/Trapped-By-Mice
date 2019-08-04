# Trapped-By-Mice
Unity Version: Unity 2018.2.7f1

## Git Repository Organization
All unity Assets go in the Unity asssets folder
Images for reference go under reference 
Only git related files are not under folders

## Unity Project Organization
All assets go in correspondingly labeled folder - material files go in the Materials folder, etc.
Store objects in hierarchy under correctly labeled empty object
Please use prefabs

## To play the animation
Open the Unity Scene found in LightweightTester and press play.

### Watch on Youtube
[![Youtube Link](https://img.youtube.com/vi/YOUTUBE_VIDEO_ID_HERE/0.jpg)](https://www.youtube.com/watch?v=-tqM7DWqZbk)

## Pipeline

In order to provide the highest visual fidelity and allow us to mess with fancier materials that perform better with global illumination and support sub-surface scattering we will use the HD render pipeline.

Light will be a mixture of baked and realtime lights. Baked lighting will allow for the bouncing of the atmosphere lights and combined with ambient occlusion we will be able to create a more fully lit scene as a whole. As of now it does not appear that any lights will be moving so it would be appropriate for them to be in a mixed mode in order to support light bounce while still being able to animate and cast shadows on the scene as it animates. Light probes may also be utilized in order to improve lighting for non-static objects. Some reflection probes may be used to help with the shininess of the plastic.

## Inter-op plan
For the most part we will be importing only one version of each animation in order to do less work. We will nest various scene timelines within one master timeline in order to ensure that if we ever do need to switch out an animation it will not be too difficult. 

Most of the hard work of importing will be done in Maya where we will make sure to bake out our animations so it plays nicely in unity. Some models may have extra triangles baked into them using sub-devision in order to better match Maya which renders with subdivision by default. These subdivisions will mostly be focused on difficult geometry like the stairs.

Textures and other assets can be updated rather easy by pushing new versions to git LFS. However we will avoid doing this too often in order to avoid issues.

## Collaborations:
We aim to collaborate mostly through prefabs and only bring everything together once each person’s respective workload is encapsulated within a prefab successfully. Timelines should allow us to do some splitting up when it comes to the final animation however we will have to be cautious as we don’t know for sure how these objects work. Work will be distributed evenly based on the storyboard and we will pick up slack for members that are not active in the group.

## Material Pipeline

There are so few materials in this project that a VERY simple material pipeline is appropriate. Essentailly there are the plastics, the board, the mice, and the cheese. For each of these we simply played around with their values starting from known values we could find online. We label each material with what it represents in the scene which is appropriate considering how few of them there truly are.
