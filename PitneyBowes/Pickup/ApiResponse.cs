namespace PitneyBowes.Pickup
{
    internal class ApiResponse<T>
    {
        private int localVarStatusCode;
        private object value;
        private SchedulePickupResponse schedulePickupResponse;

        public ApiResponse(int localVarStatusCode, object value, SchedulePickupResponse schedulePickupResponse)
        {
            this.localVarStatusCode = localVarStatusCode;
            this.value = value;
            this.schedulePickupResponse = schedulePickupResponse;
        }
    }
}