using System;

namespace OneSignal.Resources.Devices
{
    /// <summary>
    /// Interface used to unify creation of classes used to help client add or edit device.
    /// </summary>
    public interface IDevicesResource
    {
        /// <summary>
        /// Adds new device into OneSignal App.
        /// </summary>
        /// <param name="options">Here you can specify options used to add new device.</param>
        /// <returns>Result of device add operation.</returns>
        DeviceAddResult Add(DeviceAddOptions options);

        /// <summary>
        /// Edits existing device defined in OneSignal App.
        /// </summary>
        /// <param name="id">Id of the device</param>
        /// <param name="options">Options used to modify attributes of the device.</param>
        /// <exception cref="Exception"></exception>
        void Edit(string id, DeviceEditOptions options);
    }
}
