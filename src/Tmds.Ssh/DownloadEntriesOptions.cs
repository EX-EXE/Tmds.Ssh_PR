// This file is part of Tmds.Ssh which is released under MIT.
// See file LICENSE for full license details.

namespace Tmds.Ssh;

public sealed class DownloadEntriesOptions
{
    public bool Overwrite { get; set; } = false;
    public bool RecurseSubdirectories { get; set; } = true;
    public bool FollowFileLinks { get; set; } = true;
    public bool FollowDirectoryLinks { get; set; } = true;
    public UnixFileTypeFilter FileTypeFilter { get; set; } =
        UnixFileTypeFilter.RegularFile |
        UnixFileTypeFilter.Directory |
        UnixFileTypeFilter.SymbolicLink;
    public SftpFileEntryPredicate? ShouldRecurse { get; set; }
    public SftpFileEntryPredicate? ShouldInclude { get; set; }
}