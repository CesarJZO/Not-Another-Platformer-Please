//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Input/PlayerActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Input
{
    public partial class @PlayerActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Ground"",
            ""id"": ""45393ecb-afe4-49ed-9269-f2337782eb02"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""01b50ed7-53e2-493c-9ff6-5e6c68e89828"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""fde01039-a43c-4d38-a14c-67420fb2d3db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f4685aef-6a1e-4f2e-aa52-1388e6401d5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6957c8df-c4e9-4769-98a4-e7a6c5c32f38"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d936c21-b867-4667-8ee9-15a2873c6b39"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""NES"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""218d4855-dbc6-41b4-8b05-ad63128d36d9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ca7d728-0c4e-41dc-9ce7-c6a9b3a58ad1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af61792a-6f1a-4e8c-8a23-500ed8b63f15"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a2f4cc7-dc5f-47e8-b98d-d59097f2580c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0c86922d-6dab-481c-82b2-7b0b3a289b99"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0a87a988-d495-4d57-8654-a2bb585287dd"",
                    ""path"": ""<XInputController>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""NES"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd6108c6-2aac-4757-9bd8-d8b6dd00f114"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""NES"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f740745c-fd46-4ee1-ba15-f7c1ea3bcdad"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03757c78-b686-4ded-89ae-9044753b2ed4"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""NES"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""NES"",
            ""bindingGroup"": ""NES"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Ground
            m_Ground = asset.FindActionMap("Ground", throwIfNotFound: true);
            m_Ground_Jump = m_Ground.FindAction("Jump", throwIfNotFound: true);
            m_Ground_Move = m_Ground.FindAction("Move", throwIfNotFound: true);
            m_Ground_Shoot = m_Ground.FindAction("Shoot", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Ground
        private readonly InputActionMap m_Ground;
        private List<IGroundActions> m_GroundActionsCallbackInterfaces = new List<IGroundActions>();
        private readonly InputAction m_Ground_Jump;
        private readonly InputAction m_Ground_Move;
        private readonly InputAction m_Ground_Shoot;
        public struct GroundActions
        {
            private @PlayerActions m_Wrapper;
            public GroundActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Ground_Jump;
            public InputAction @Move => m_Wrapper.m_Ground_Move;
            public InputAction @Shoot => m_Wrapper.m_Ground_Shoot;
            public InputActionMap Get() { return m_Wrapper.m_Ground; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GroundActions set) { return set.Get(); }
            public void AddCallbacks(IGroundActions instance)
            {
                if (instance == null || m_Wrapper.m_GroundActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GroundActionsCallbackInterfaces.Add(instance);
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }

            private void UnregisterCallbacks(IGroundActions instance)
            {
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Shoot.started -= instance.OnShoot;
                @Shoot.performed -= instance.OnShoot;
                @Shoot.canceled -= instance.OnShoot;
            }

            public void RemoveCallbacks(IGroundActions instance)
            {
                if (m_Wrapper.m_GroundActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGroundActions instance)
            {
                foreach (var item in m_Wrapper.m_GroundActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GroundActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GroundActions @Ground => new GroundActions(this);
        private int m_KeyboardSchemeIndex = -1;
        public InputControlScheme KeyboardScheme
        {
            get
            {
                if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
                return asset.controlSchemes[m_KeyboardSchemeIndex];
            }
        }
        private int m_NESSchemeIndex = -1;
        public InputControlScheme NESScheme
        {
            get
            {
                if (m_NESSchemeIndex == -1) m_NESSchemeIndex = asset.FindControlSchemeIndex("NES");
                return asset.controlSchemes[m_NESSchemeIndex];
            }
        }
        public interface IGroundActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
        }
    }
}
