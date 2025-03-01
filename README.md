# VR-Room

## Overview
This VR Room project, developed for the Meta Quest 3 using Unity and C#, aims to create an immersive environment where users can freely move, interact with objects, and enjoy a seamless virtual reality experience. The project includes multiple interactive elements, performance-focused design, and visually appealing post-processing effects.

## Features

1. **Interactive Environment**
   - **UI Canvas:** Utilized world-space canvases for VR menus.
   - **Object Interactions:** Created XR Grabbable objects, such as a tennis ball, hats that users can pick up or wear, and added a remote to turn on a TV.
   - **Sockets:** Employed sockets for easy object placement and neat snapping mechanisms.

2. **Teleportation & Locomotion**
   - Implemented teleportation-based movement to enhance user comfort. Users can choose between continuous movement and teleportation from the settings UI canvas.
   - Incorporated fade transitions to reduce motion sickness during travel.

3. **Immersive Design**
   - **Post-Processing:** Applied anti-aliasing and other visual effects for a polished look.
   - **Lighting:** Mixed real-time and baked lighting to balance realism and performance.

4. **Optimization Techniques**
   - **Performance Tuning:** Reduced draw calls, used LODs, and optimized scripts to maintain a stable frame rate. Utilized a static method to further reduce processing overhead.
   - **Quest 3 Compatibility:** Ensured the project runs smoothly on Quest 3 hardware by managing CPU and GPU usage.

## Key VR Concepts

1. **User-Friendly Interactions**
   - Leveraged XR Interaction Toolkit for natural hand-based object grabbing, throwing, and wearing.
   - Focused on intuitive experiences to help users feel grounded in the virtual space.

2. **Comfort & Accessibility**
   - Offered teleportation to minimize motion sickness.
   - Incorporated adjustable settings to allow users to tailor the experience to their comfort level.


## Performance Insights

### Preface
This section captures real-time performance data collected during gameplay, focusing on CPU, GPU, and frame rate stability. These insights help identify effective optimizations and potential areas of improvement.

### CPU & GPU Utilization
**Observations**
- **CPU Usage:** Frequently hovers between moderate ranges, indicating balanced processing overhead. Occasional spikes may occur during peak interactions or transitions.
- **GPU Usage:**  Remains within comfortable thresholds, suggesting the project is well-optimized for VR rendering and visual effects.


## Overall Observations
- **Optimized VR Experience:** The stable frame rates and balanced CPU/GPU usage indicate strong optimization.
- **Immersive & Interactive:** Integration of XR interactions, object sockets, and post-processing contributes to a polished user experience.
- **Future Possibilities:** Further improvements could focus on advanced visual effects, more complex AI-driven interactions, and refined CPU load distribution.

---
This VR Room project demonstrates a successful blend of performance optimization, interactive design, and immersive visuals—all tailored for the Meta Quest 3. By combining user-friendly interactions with efficient rendering, this experience is both captivating and comfortable, establishing a solid foundation for future VR endeavors.
