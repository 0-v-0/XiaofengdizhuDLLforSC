﻿//使用时取消注释
/*
using Engine;
using Engine.Graphics;
using Engine.Input;
using System;

namespace Game
{
    public class SkillPlayBadAppleBy4LED : Skill
    {
        private PlayBadAppleBy4LED m_playBadAppleBy4LED = new PlayBadAppleBy4LED();
        private bool m_isPlaying;
        private DateTime m_startTime;
        public override string Name
        {
            get { return "PlayBadAppleBy4LED"; }
        }
        public override bool Input()
        {
            if (Keyboard.IsKeyDownOnce(Key.O))
            {
                if (m_isPlaying)
                {
                    m_playBadAppleBy4LED.m_music.Stop();
                    m_playBadAppleBy4LED.m_music.Play();
                    m_startTime = DateTime.Now;
                }
                else
                {
                    m_playBadAppleBy4LED.m_music.Play();
                    m_startTime = DateTime.Now;
                    m_isPlaying = true;
                }
            }
            else if (Keyboard.IsKeyDownRepeat(Key.O))
            {
                m_playBadAppleBy4LED.m_music.Stop();
                m_isPlaying = false;
            }
            if (m_isPlaying) return true; else return false;
        }
        public override void Action()
        {
            TimeSpan timePlayed = DateTime.Now - m_startTime;
            int m_pictureIndex = (int)(timePlayed.TotalSeconds * 30);
            if (m_pictureIndex > 6574)
            {
                m_startTime = DateTime.Now;
                m_pictureIndex = 0;
            }
            m_playBadAppleBy4LED.Play(m_pictureIndex);
            Vector3 playerPosition = commonMethod.playerPosition;
            float distance = MathUtils.Sqrt(Vector3.DistanceSquared(playerPosition, new Vector3(36, 2, 27)));
            float volume = 1;
            float minDistance = 4;
            float rolloffFactor = 2;
            if (distance > minDistance) volume = minDistance / (minDistance + MathUtils.Max(rolloffFactor * (distance - minDistance), 0f));
            m_playBadAppleBy4LED.m_music.Volume = volume;
        }
    }
}
*/