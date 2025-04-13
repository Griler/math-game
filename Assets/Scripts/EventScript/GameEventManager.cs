using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.Events;

public static class GameEventManager
{
    private static Dictionary<string, UnityAction> eventMap = new Dictionary<string, UnityAction>();

    // Đăng ký callback cho 1 event
    public static void Subscribe(string eventName, UnityAction callback)
    {
        if (!eventMap.ContainsKey(eventName))
            eventMap[eventName] = callback;
        else
            eventMap[eventName] += callback;
    }

    // Bỏ đăng ký callback
    public static void Unsubscribe(string eventName, UnityAction callback)
    {
        if (eventMap.ContainsKey(eventName))
        {
            eventMap[eventName] -= callback;
            if (eventMap[eventName] == null)
                eventMap.Remove(eventName);
        }
    }

    // Gọi event
    public static void Raise(string eventName)
    {
        if (eventMap.ContainsKey(eventName))
        {
            eventMap[eventName]?.Invoke();
        }
        else
        {
            Debug.LogWarning($"⚠️ Event '{eventName}' not Subscribe.");
        }
    }
}