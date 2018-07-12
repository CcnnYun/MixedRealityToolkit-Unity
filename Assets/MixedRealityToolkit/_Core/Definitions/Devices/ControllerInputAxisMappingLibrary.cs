﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities;
using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.Internal.Definitions.Devices
{
    public static class ControllerInputAxisMappingLibrary
    {
        #region Controller axis mapping configuration

        #region OpenVR

        private static readonly string[] OpenVRInputMappings =
        {
            "OPENVR_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 0 - TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL
            "OPENVR_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 1 - TOUCHPAD_LEFT_CONTROLLER_VERTICAL
            "OPENVR_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 2 - TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL
            "OPENVR_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 3 - TOUCHPAD_RIGHT_CONTROLLER_VERTICAL
            "OPENVR_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 4 - THUMBSTICK_LEFT_CONTROLLER_HORIZONTAL
            "OPENVR_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 5 - THUMBSTICK_LEFT_CONTROLLER_VERTICAL
            "OPENVR_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 6 - THUMBSTICK_RIGHT_CONTROLLER_HORIZONTAL
            "OPENVR_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 7 - THUMBSTICK_RIGHT_CONTROLLER_VERTICAL
            "OPENVR_TRIGGER_LEFT_CONTROLLER",               // 8 - TRIGGER_LEFT_CONTROLLER
            "OPENVR_TRIGGER_RIGHT_CONTROLLER",              // 9 - TRIGGER_RIGHT_CONTROLLER
            "OPENVR_GRIP_LEFT_CONTROLLER",                  // 10 - GRIP_LEFT_CONTROLLER
            "OPENVR_GRIP_RIGHT_CONTROLLER"                  // 11 - GRIP_RIGHT_CONTROLLER
        };

        private static InputManagerAxis[] OpenVRControllerAxisMappings = new InputManagerAxis[]
        {
            new InputManagerAxis() { Name = OpenVRInputMappings[0], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1 },
            new InputManagerAxis() { Name = OpenVRInputMappings[1], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2 },
            new InputManagerAxis() { Name = OpenVRInputMappings[2], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4 },
            new InputManagerAxis() { Name = OpenVRInputMappings[3], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5 },
            new InputManagerAxis() { Name = OpenVRInputMappings[4], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1 },
            new InputManagerAxis() { Name = OpenVRInputMappings[5], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2 },
            new InputManagerAxis() { Name = OpenVRInputMappings[6], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4 },
            new InputManagerAxis() { Name = OpenVRInputMappings[7], Dead = 0.1f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5 },
            new InputManagerAxis() { Name = OpenVRInputMappings[8], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 9 },
            new InputManagerAxis() { Name = OpenVRInputMappings[9], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 10 },
            new InputManagerAxis() { Name = OpenVRInputMappings[10], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 11 },
            new InputManagerAxis() { Name = OpenVRInputMappings[11], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 12 }
        };

        #endregion OpenVR

        #region HTCVive

        private static readonly string[] HTCViveInputMappings =
        {
            "VIVE_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 0 - TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL
            "VIVE_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 1 - TOUCHPAD_LEFT_CONTROLLER_VERTICAL
            "VIVE_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 2 - TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL
            "VIVE_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 3 - TOUCHPAD_RIGHT_CONTROLLER_VERTICAL
            "VIVE_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 4 - THUMBSTICK_LEFT_CONTROLLER_HORIZONTAL
            "VIVE_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 5 - THUMBSTICK_LEFT_CONTROLLER_VERTICAL
            "VIVE_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 6 - THUMBSTICK_RIGHT_CONTROLLER_HORIZONTAL
            "VIVE_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 7 - THUMBSTICK_RIGHT_CONTROLLER_VERTICAL
            "VIVE_TRIGGER_LEFT_CONTROLLER",               // 8 - TRIGGER_LEFT_CONTROLLER
            "VIVE_TRIGGER_RIGHT_CONTROLLER",              // 9 - TRIGGER_RIGHT_CONTROLLER
            "VIVE_GRIP_LEFT_CONTROLLER",                  // 10 - GRIP_LEFT_CONTROLLER
            "VIVE_GRIP_RIGHT_CONTROLLER"                  // 11 - GRIP_RIGHT_CONTROLLER
        };

        private static InputManagerAxis[] HTCViveControllerAxisMappings = new InputManagerAxis[]
        {
            new InputManagerAxis() { Name = HTCViveInputMappings[0], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1 },
            new InputManagerAxis() { Name = HTCViveInputMappings[1], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2 },
            new InputManagerAxis() { Name = HTCViveInputMappings[2], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4 },
            new InputManagerAxis() { Name = HTCViveInputMappings[3], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5 },
            new InputManagerAxis() { Name = HTCViveInputMappings[8], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 9 },
            new InputManagerAxis() { Name = HTCViveInputMappings[9], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 10 },
            new InputManagerAxis() { Name = HTCViveInputMappings[10], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 11 },
            new InputManagerAxis() { Name = HTCViveInputMappings[11], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 12 }
        };

        #endregion HTCVive

        #region OculusTouch
        
        private static readonly string[] OculusTouchInputMappings =
        {
            "OTOUCH_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 0 - TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL
            "OTOUCH_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 1 - TOUCHPAD_LEFT_CONTROLLER_VERTICAL
            "OTOUCH_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 2 - TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL
            "OTOUCH_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 3 - TOUCHPAD_RIGHT_CONTROLLER_VERTICAL
            "OTOUCH_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 4 - THUMBSTICK_LEFT_CONTROLLER_HORIZONTAL
            "OTOUCH_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 5 - THUMBSTICK_LEFT_CONTROLLER_VERTICAL
            "OTOUCH_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 6 - THUMBSTICK_RIGHT_CONTROLLER_HORIZONTAL
            "OTOUCH_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 7 - THUMBSTICK_RIGHT_CONTROLLER_VERTICAL
            "OTOUCH_TRIGGER_LEFT_CONTROLLER",               // 8 - TRIGGER_LEFT_CONTROLLER
            "OTOUCH_TRIGGER_RIGHT_CONTROLLER",              // 9 - TRIGGER_RIGHT_CONTROLLER
            "OTOUCH_GRIP_LEFT_CONTROLLER",                  // 10 - GRIP_LEFT_CONTROLLER
            "OTOUCH_GRIP_RIGHT_CONTROLLER"                  // 11 - GRIP_RIGHT_CONTROLLER
        };

        private static InputManagerAxis[] OculusTouchControllerAxisMappings = new InputManagerAxis[]
        {
            new InputManagerAxis() { Name = OculusTouchInputMappings[0], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[1], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[2], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[3], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[8], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 9 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[9], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 10 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[10], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 11 },
            new InputManagerAxis() { Name = OculusTouchInputMappings[11], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 12 }
        };

        #endregion

        #region ValveKnuckles
        
        private static readonly string[] ValveKnucklesInputMappings =
        {
            "VKNUCKLES_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 0 - TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL
            "VKNUCKLES_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 1 - TOUCHPAD_LEFT_CONTROLLER_VERTICAL
            "VKNUCKLES_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 2 - TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL
            "VKNUCKLES_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 3 - TOUCHPAD_RIGHT_CONTROLLER_VERTICAL
            "VKNUCKLES_TOUCHPAD_LEFT_CONTROLLER_HORIZONTAL",   // 4 - THUMBSTICK_LEFT_CONTROLLER_HORIZONTAL
            "VKNUCKLES_TOUCHPAD_LEFT_CONTROLLER_VERTICAL",     // 5 - THUMBSTICK_LEFT_CONTROLLER_VERTICAL
            "VKNUCKLES_TOUCHPAD_RIGHT_CONTROLLER_HORIZONTAL",  // 6 - THUMBSTICK_RIGHT_CONTROLLER_HORIZONTAL
            "VKNUCKLES_TOUCHPAD_RIGHT_CONTROLLER_VERTICAL",    // 7 - THUMBSTICK_RIGHT_CONTROLLER_VERTICAL
            "VKNUCKLES_TRIGGER_LEFT_CONTROLLER",               // 8 - TRIGGER_LEFT_CONTROLLER
            "VKNUCKLES_TRIGGER_RIGHT_CONTROLLER",              // 9 - TRIGGER_RIGHT_CONTROLLER
            "VKNUCKLES_GRIP_LEFT_CONTROLLER",                  // 10 - GRIP_LEFT_CONTROLLER
            "VKNUCKLES_GRIP_RIGHT_CONTROLLER",                 // 11 - GRIP_RIGHT_CONTROLLER
            "VKNUCKLES_INDEXFINGER_LEFT_CONTROLLER",           // 12 - INDEXFINGER_LEFT_CONTROLLER
            "VKNUCKLES_INDEXFINGER_RIGHT_CONTROLLER",          // 13 - INDEXFINGER_RIGHT_CONTROLLER
            "VKNUCKLES_MIDDLEFINGER_LEFT_CONTROLLER",          // 14 - MIDDLEFINGER_LEFT_CONTROLLER
            "VKNUCKLES_MIDDLEFINGER_RIGHT_CONTROLLER",         // 15 - MIDDLEFINGER_RIGHT_CONTROLLER
            "VKNUCKLES_RINGFINGER_LEFT_CONTROLLER",            // 16 - RINGFINGER_LEFT_CONTROLLER
            "VKNUCKLES_RINGFINGER_RIGHT_CONTROLLER",           // 17 - RINGFINGER_RIGHT_CONTROLLER
            "VKNUCKLES_PINKYFINGER_LEFT_CONTROLLER",           // 18 - PINKYFINGER_LEFT_CONTROLLER
            "VKNUCKLES_PINKYFINGER_RIGHT_CONTROLLER",          // 19 - PINKYFINGER_RIGHT_CONTROLLER
        };

        private static InputManagerAxis[] ValveKnucklesControllerAxisMappings = new InputManagerAxis[]
        {
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[0], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 1 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[1], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 2 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[2], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 4 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[3], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 5 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[8], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 9 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[9], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 10 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[10], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 11 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[11], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 12 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[12], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 20 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[13], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 21 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[14], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 22 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[15], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 23 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[16], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 24 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[17], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 25 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[18], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 26 },
            new InputManagerAxis() { Name = ValveKnucklesInputMappings[19], Dead = 0.001f, Sensitivity = 1, Invert = false, Type = InputManagerAxisType.JoystickAxis, Axis = 27 }
        };

        #endregion ValveKnuckles

        #endregion Controller axis mapping configuration

        #region Controller axis library

        private static Dictionary<string, InputManagerAxis[]> InputManagerAxis = new Dictionary<string, InputManagerAxis[]>()
        {
            { typeof(Internal.Devices.OpenVR.GenericOpenVRController).FullName, OpenVRControllerAxisMappings },
            { typeof(Internal.Devices.OpenVR.HTCViveController).FullName, HTCViveControllerAxisMappings },
            { typeof(Internal.Devices.OpenVR.OculusTouchController).FullName, OculusTouchControllerAxisMappings },
            { typeof(Internal.Devices.OpenVR.ValveKnucklesController).FullName, ValveKnucklesControllerAxisMappings },
        };

        private static Dictionary<string, string[]> InputManagerMappings = new Dictionary<string, string[]>()
        {
            { typeof(Internal.Devices.OpenVR.GenericOpenVRController).FullName, OpenVRInputMappings },
            { typeof(Internal.Devices.OpenVR.HTCViveController).FullName, HTCViveInputMappings },
            { typeof(Internal.Devices.OpenVR.OculusTouchController).FullName, OculusTouchInputMappings },
            { typeof(Internal.Devices.OpenVR.ValveKnucklesController).FullName, ValveKnucklesInputMappings },
        };

        #endregion Controller axis library

        public static InputManagerAxis[] GetInputManagerAxes(string type)
        {
            return InputManagerAxis.ContainsKey(type) ? InputManagerAxis[type] :  default(InputManagerAxis[]);
        }

        public static string[] GetInputManagerMappings(string type)
        {
            return InputManagerMappings.ContainsKey(type) ? InputManagerMappings[type] : default(string[]);
        }
    }
}