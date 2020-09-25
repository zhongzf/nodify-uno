﻿namespace Nodify.Playground
{
    public class EditorSettings : ObservableObject
    {
        private EditorSettings() { }

        public static EditorSettings Instance { get; } = new EditorSettings();

        #region Default settings

        private bool _enablePendingConnectionSnapping = true;
        public bool EnablePendingConnectionSnapping
        {
            get => _enablePendingConnectionSnapping;
            set => SetProperty(ref _enablePendingConnectionSnapping, value);
        }

        private bool _enablePendingConnectionPreview = true;
        public bool EnablePendingConnectionPreview
        {
            get => _enablePendingConnectionPreview;
            set => SetProperty(ref _enablePendingConnectionPreview, value);
        }

        private bool _allowConnectingToConnectorsOnly;
        public bool AllowConnectingToConnectorsOnly
        {
            get => _allowConnectingToConnectorsOnly;
            set => SetProperty(ref _allowConnectingToConnectorsOnly, value);
        }

        private bool _realtimeSelection = true;
        public bool EnableRealtimeSelection
        {
            get => _realtimeSelection;
            set => SetProperty(ref _realtimeSelection, value);
        }

        private bool _disableAutoPanning = false;
        public bool DisableAutoPanning
        {
            get => _disableAutoPanning;
            set => SetProperty(ref _disableAutoPanning, value);
        }

        private double _autoPanningSpeed = 10d;
        public double AutoPanningSpeed
        {
            get => _autoPanningSpeed;
            set => SetProperty(ref _autoPanningSpeed, value);
        }

        public double _autoPanningEdgeDistance = 15d;
        public double AutoPanningEdgeDistance
        {
            get => _autoPanningEdgeDistance;
            set => SetProperty(ref _autoPanningEdgeDistance, value);
        }

        private bool _disablePanning = false;
        public bool DisablePanning
        {
            get => _disablePanning;
            set => SetProperty(ref _disablePanning, value);
        }

        private bool _disableZooming = false;
        public bool DisableZooming
        {
            get => _disableZooming;
            set => SetProperty(ref _disableZooming, value);
        }

        private uint _gridSpacing = 15u;
        public uint GridSpacing
        {
            get => _gridSpacing;
            set => SetProperty(ref _gridSpacing, value);
        }

        private double _minZoom = 0.1;
        public double MinZoom
        {
            get => _minZoom;
            set => SetProperty(ref _minZoom, value);
        }

        private double _maxZoom = 2;
        public double MaxZoom
        {
            get => _maxZoom;
            set => SetProperty(ref _maxZoom, value);
        }

        #endregion

        #region Advanced settings

        public double HandleRightClickAfterPanningThreshold
        {
            get => NodifyEditor.HandleRightClickAfterPanningThreshold;
            set => NodifyEditor.HandleRightClickAfterPanningThreshold = value;
        }

        public bool EnableSnappingCorrection
        {
            get => NodifyEditor.EnableSnappingCorrection;
            set => NodifyEditor.EnableSnappingCorrection = value;
        }

        public double AutoPanningTickRate
        {
            get => NodifyEditor.AutoPanningTickRate;
            set => NodifyEditor.AutoPanningTickRate = value;
        }

        public double OptimizeSafeZone
        {
            get => Connector.OptimizeSafeZone;
            set => Connector.OptimizeSafeZone = value;
        }

        public uint OptimizeMinimumSelectedItems
        {
            get => Connector.OptimizeMinimumSelectedItems;
            set => Connector.OptimizeMinimumSelectedItems = value;
        }

        public bool EnableConnectorOptimizations
        {
            get => Connector.EnableOptimizations;
            set => Connector.EnableOptimizations = value;
        }

        #endregion
    }
}