using Windows.Networking.Connectivity;

namespace HttpUtillity.Util
{
    public sealed class NetworkUtil
    {
        public static bool IsNetworkAvailable()
        {
            ConnectionProfile InternetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();

            if (InternetConnectionProfile == null)
            {
                return false;
            }

            NetworkConnectivityLevel level = InternetConnectionProfile.GetNetworkConnectivityLevel();
            return level == NetworkConnectivityLevel.InternetAccess;
        }
    }
}
