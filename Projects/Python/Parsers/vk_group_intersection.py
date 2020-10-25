import vk

def get_users(groupid):
    start = vk_api.groups.getMembers(group_id=groupid, v=5.124)
    info = start["items"]
    count = start["count"] // 1000
    for i in range(1, count + 1):
        info = info + vk_api.groups.getMembers(group_id=groupid, v=5.124, offset=i * 1000)["items"]
    return info

def get_intersection(group1, group2):
    group1 = set(group1)
    group2 = set(group2)
    intersection = group1.intersection(group2)
    print(f'Количество пользователей, находящихся в обоих сообществах: {len(intersection)}')
    return list(intersection)


def merge_users(group1, group2):
    group1 = set(group1)
    group2 = set(group2)
    union = group1.union(group2)
    return list(union)


def save_info(info, filename="info.txt"):
    with open(filename, "w") as file:
        for item in info:
            file.write(f'vk.com/id{str(item)}\n')


def extract_info(filename="info.txt"):
    with open(filename) as file:
        l = []
        for line in file:
            l.append(line[9:len(line) - 1])
    return l


if __name__ == "__main__":
    token = "Add your token here"
    session = vk.Session(access_token=token)
    vk_api = vk.API(session)
    community_1 = get_users("name(id) coomunity")
    community_2 = get_users("name(id) coomunity")
    get_intersection(community_1, community_2)
    union = merge_users(community_1, community_2)
    save_info(union)
