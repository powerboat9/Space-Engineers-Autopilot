List<IMyThrust> getThrusters()
    List<IMyThrust> thrusters = new List<IMyTerminalBlock>();
    GridTerminalSystem.getBlocksOfType<IMyThrust>(thrusters);
    return thrusters;
}

void Main() {
    List<IM
}
