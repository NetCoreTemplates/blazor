## App Writable Folder

This directory is designated for:

- **Embedded Databases**: Such as SQLite.
- **Writable Files**: A location where your application can read and write files as a part of its operation.

For applications running in **Docker**, it's a common practice to mount this directory as an external volume. This ensures:

- **Data Persistence**: App data is preserved across deployments.
- **Easy Replication**: Facilitates seamless data replication for backup or migration purposes.

Note, files added to this directory won't be deployed with your application since it is used as a mounted volume, and files created by your application will persist between deployments.