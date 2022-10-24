namespace State
{
    public class Context
    {
        private State _currentState;
        public int AvailableCash { get; set; } = 200_000;

        public Context()
        {
            _currentState = new NoCard(this);
        }

        public void ChangeState(State newState)
        {
            _currentState = newState;
        }

        public void InsertCard()
        {
            _currentState.InsertCard();
        }

        public void EjectCard()
        {
            _currentState.EjectCard();
        }

        public void InsertPin(int pin)
        {
            _currentState.InsertPin(pin);
        }

        public void WithdrawCash(int amount)
        {
            _currentState.WithdrawCash(amount);
        }
    }
}