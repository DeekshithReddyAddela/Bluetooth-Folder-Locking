namespace btprox
{
    class StateMachine
    {
        /// <summary>
        /// current state of this state machine
        /// </summary>
        private State m_state;

        /// <summary>
        /// description of states of the program
        /// </summary>
        private enum State
        {
            Start,
            DeviceInRange,
            DeviceNotInRange,
            Countdown,
            LockedOrLockAborted
        }

        /// <summary>
        /// action required after state machine iteration
        /// </summary>
        internal enum Action
        {
            None,
            Lock,
            Unlock,
            StartTimer,
            AbortTimer,
            ShowDeviceAppearance,
            Countdown
        }

        /// <summary>
        /// create and initialize the state machine
        /// </summary>
        public StateMachine()
        {
            m_state = State.Start;
        }

        /// <summary>
        /// find the next state of the state machine
        /// </summary>
        ///
        /// <param name="isDeviceInRange">
        /// is the device in range currently?
        /// </param>
        ///
        /// <param name="isTimeout">
        /// is timeout reached
        /// </param>
        ///
        /// <returns>
        /// action to be taken by the caller
        /// </returns>
        public Action Iterate(bool isDeviceInRange, bool isTimeout)
        {
            switch (m_state)
            {
            case State.Start:
                if (isDeviceInRange)
                {
                    m_state = State.DeviceInRange;
                    return Action.ShowDeviceAppearance;
                }
                return Action.None;
            case State.DeviceInRange:
                if (!isDeviceInRange)
                {
                    m_state = State.DeviceNotInRange;
                    return Action.StartTimer;
                }
                return Action.None;
            case State.DeviceNotInRange:
                if (isDeviceInRange)
                {
                    m_state = State.DeviceInRange;
                    return Action.AbortTimer;
                }
                if (isTimeout)
                {
                    m_state = State.Countdown;
                    return Action.Countdown;
                }
                return Action.None;
            case State.Countdown:
                if (isDeviceInRange)
                {
                    m_state = State.DeviceInRange;
                    return Action.ShowDeviceAppearance;
                }
                if (isTimeout)
                {
                    m_state = State.LockedOrLockAborted;
                    return Action.Lock;
                }
                return Action.None;
            case State.LockedOrLockAborted:
                if (isDeviceInRange)
                {
                    m_state = State.DeviceInRange;
                    return Action.Unlock;
                }
                return Action.None;
            default:
                return Action.None;
            }
        }
    }
}
