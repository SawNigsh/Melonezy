using UnityEngine;

namespace MalumMenu;

public static class GUIStylePreset
{
    private static GUIStyle _separator;
    private static GUIStyle _darkSeparator;
    private static GUIStyle _normalButton;
    private static GUIStyle _normalToggle;
    private static GUIStyle _tabButton;
    private static GUIStyle _tabTitle;
    private static GUIStyle _tabSubtitle;
    private static GUIStyle _panel;
    private static GUIStyle _sidebar;

    public static Texture2D CreateSolidTexture(Color color)
    {
        var texture = new Texture2D(1, 1, TextureFormat.RGBA32, false);
        texture.SetPixel(0, 0, color);
        texture.Apply();
        return texture;
    }

    public static GUIStyle Panel
    {
        get
        {
            if (_panel == null)
            {
                _panel = new GUIStyle(GUI.skin.box)
                {
                    border = new RectOffset(),
                    padding = new RectOffset(12, 12, 12, 12),
                    margin = new RectOffset(8, 8, 8, 8),
                    normal =
                    {
                        background = CreateSolidTexture(new Color(0.12f, 0.15f, 0.21f, 1f)),
                        textColor = new Color(0.96f, 0.98f, 1f, 1f)
                    },
                    hover =
                    {
                        background = CreateSolidTexture(new Color(0.14f, 0.17f, 0.24f, 1f))
                    }
                };
            }

            return _panel;
        }
    }

    public static GUIStyle Sidebar
    {
        get
        {
            if (_sidebar == null)
            {
                _sidebar = new GUIStyle(GUI.skin.box)
                {
                    border = new RectOffset(),
                    padding = new RectOffset(10, 10, 10, 10),
                    margin = new RectOffset(0, 10, 0, 0),
                    normal =
                    {
                        background = CreateSolidTexture(new Color(0.09f, 0.12f, 0.17f, 1f)),
                        textColor = new Color(0.92f, 0.96f, 1f, 1f)
                    }
                };
            }

            return _sidebar;
        }
    }

    public static GUIStyle Separator
    {
        get
        {
            if (_separator == null)
            {
                _separator = new GUIStyle(GUI.skin.box)
                {
                    normal = { background = CreateSolidTexture(new Color(0.31f, 0.46f, 0.92f, 0.8f)) },
                    margin = new RectOffset(0, 8, 0, 0),
                    padding = new RectOffset(),
                    border = new RectOffset()
                };
            }

            return _separator;
        }
    }

    public static GUIStyle DarkSeparator
    {
        get
        {
            if (_darkSeparator == null)
            {
                _darkSeparator = new GUIStyle(GUI.skin.box)
                {
                    normal = { background = CreateSolidTexture(new Color(0.18f, 0.21f, 0.29f, 1f)) },
                    margin = new RectOffset(0, 0, 0, 0),
                    padding = new RectOffset(),
                    border = new RectOffset()
                };
            }

            return _darkSeparator;
        }
    }

    public static GUIStyle NormalButton
    {
        get
        {
            if (_normalButton == null)
            {
                _normalButton = new GUIStyle(GUI.skin.button)
                {
                    fontSize = 13,
                    border = new RectOffset(8, 8, 6, 6),
                    padding = new RectOffset(10, 10, 7, 7),
                    normal =
                    {
                        background = CreateSolidTexture(new Color(0.21f, 0.24f, 0.35f, 1f)),
                        textColor = new Color(0.94f, 0.97f, 1f, 1f)
                    },
                    hover =
                    {
                        background = CreateSolidTexture(new Color(0.28f, 0.34f, 0.47f, 1f))
                    },
                    active =
                    {
                        background = CreateSolidTexture(new Color(0.36f, 0.48f, 0.96f, 1f))
                    }
                };
            }

            return _normalButton;
        }
    }

    public static GUIStyle NormalToggle
    {
        get
        {
            if (_normalToggle == null)
            {
                _normalToggle = new GUIStyle(GUI.skin.toggle)
                {
                    fontSize = 13,
                    padding = new RectOffset(18, 0, 2, 2),
                    normal =
                    {
                        textColor = new Color(0.94f, 0.97f, 1f, 1f)
                    },
                    onNormal =
                    {
                        textColor = new Color(0.94f, 0.97f, 1f, 1f)
                    }
                };
            }

            return _normalToggle;
        }
    }

    public static GUIStyle TabButton
    {
        get
        {
            if (_tabButton == null)
            {
                _tabButton = new GUIStyle(GUI.skin.button)
                {
                    fontSize = 15,
                    fontStyle = FontStyle.Bold,
                    border = new RectOffset(10, 10, 8, 8),
                    padding = new RectOffset(8, 8, 8, 8),
                    alignment = TextAnchor.MiddleLeft,
                    normal =
                    {
                        background = CreateSolidTexture(new Color(0.13f, 0.16f, 0.22f, 1f)),
                        textColor = new Color(0.85f, 0.9f, 1f, 1f)
                    },
                    hover =
                    {
                        background = CreateSolidTexture(new Color(0.18f, 0.22f, 0.31f, 1f))
                    },
                    active =
                    {
                        background = CreateSolidTexture(new Color(0.35f, 0.46f, 0.9f, 1f)),
                        textColor = new Color(1f, 1f, 1f, 1f)
                    }
                };
            }

            return _tabButton;
        }
    }

    public static GUIStyle TabTitle
    {
        get
        {
            if (_tabTitle == null)
            {
                _tabTitle = new GUIStyle(GUI.skin.label)
                {
                    fontSize = 22,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.MiddleLeft,
                    normal =
                    {
                        textColor = new Color(0.96f, 0.98f, 1f, 1f)
                    }
                };
            }

            return _tabTitle;
        }
    }

    public static GUIStyle TabSubtitle
    {
        get
        {
            if (_tabSubtitle == null)
            {
                _tabSubtitle = new GUIStyle(GUI.skin.label)
                {
                    fontSize = 14,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.MiddleLeft,
                    normal =
                    {
                        textColor = new Color(0.54f, 0.73f, 1f, 1f)
                    }
                };
            }

            return _tabSubtitle;
        }
    }
}
